#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ACH.FileGeneration.Converters;
using ACH.Shared;

#endregion

namespace ACH.FileGeneration.RollingGenerator
{
    public class RollingMap<T> : ClassMap<T, IRollingPropertyMap>
    {
        #region Readonly & Static Fields

        private readonly IList<IRollingPropertyMap> _properties = new List<IRollingPropertyMap>();
        private readonly RollingConverter _rollingConverter = new RollingConverter();

        #endregion

        #region Instance Methods

        /// <summary>
        /// Maps the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public override IRollingPropertyMap Map(Expression<Func<T, object>> expression)
        {
            return Map(expression, null, null);
        }

        /// <summary>
        /// Writes the specified writable object.
        /// </summary>
        /// <param name="writableObject">The writable object.</param>
        /// <returns></returns>
        public override string Write(T writableObject)
        {
            var sb = new StringBuilder();

            foreach (var propertyMap in _properties)
            {
                bool? hasText = null;
                //Check if propertyMap is for a header record 
                if (propertyMap.PropertyInfo == null)
                {
                    sb.Append(propertyMap.LeadingLabel);
                }
                else
                {
                    var length = propertyMap.MaxLength;
                    var obj = propertyMap.PropertyInfo.GetValue(writableObject, null);

                    obj = propertyMap.AppliedActions.Aggregate(obj, (current, func) => func(current));

                    var stringValue = string.Format("{0}", obj);
                    hasText = stringValue.Length > 0;

                    if (length.HasValue)
                        stringValue = stringValue.Substring(0, length.Value);

                    if (hasText.Value || propertyMap.DisplayEmptyValue)
                        sb.AppendFormat("{0}{1}{2}", propertyMap.LeadingLabel, stringValue, propertyMap.TrailingNotice);
                }

                if (hasText.GetValueOrDefault(true))
                    for (int i = 0; i < propertyMap.LinesToAppend.GetValueOrDefault(-1); i++)
                        sb.AppendLine();
            }

            return sb.ToString();
        }

        /// <summary>
        /// Inserts a header record. 
        /// </summary>
        /// <param name="text">The text.</param>
        public IRollingPropertyMap Header(string text)
        {
            return Header(text, null);
        }

        /// <summary>
        /// Inserts a header record. Optionally append lines
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="linesToAppend">The number of lines to append.</param>
        public IRollingPropertyMap Header(string text, int? linesToAppend)
        {
            var propertyMap = new RollingPropertyMap {LinesToAppend = linesToAppend, LeadingLabel = text};

            _properties.Add(propertyMap);

            return propertyMap;
        }

        /// <summary>
        /// Maps the specified expression. Optionally append lines at the end.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap Map(Expression<Func<T, object>> expression, int? linesToAppend)
        {
            return Map(expression, null, linesToAppend);
        }

        /// <summary>
        /// Maps the specified expression. Uses the property name as the leading label
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name label seperator.</param>
        /// <returns></returns>
        public IRollingPropertyMap Map(Expression<Func<T, object>> expression, string propertyNameIsLabelSeperator)
        {
            return Map(expression, propertyNameIsLabelSeperator, null);
        }

        /// <summary>
        /// Maps the specified expression. Uses the property name as the leading label
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name label seperator.</param>
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap Map(Expression<Func<T, object>> expression, string propertyNameIsLabelSeperator, int? linesToAppend)
        {
            var propertyMap = GetPropertyMap(expression, propertyNameIsLabelSeperator, linesToAppend);

            _properties.Add(propertyMap);

            return propertyMap;
        }

        /// <summary>
        /// Maps the enum collection.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="expression">The expression.</param>        
        /// <returns></returns>
        public IRollingPropertyMap MapEnumCollection<TEnum>(Expression<Func<T, object>> expression)
        {
            return MapEnumCollection<TEnum>(expression, null, null);
        }


        /// <summary>
        /// Maps the enum collection. Uses the property name as the leading label
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumCollection<TEnum>(Expression<Func<T, object>> expression, string propertyNameIsLabelSeperator)
        {
            return MapEnumCollection<TEnum>(expression, propertyNameIsLabelSeperator, null);
        }

        /// <summary>
        /// Maps the enum collection. Uses the property name as the leading label
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumCollection<TEnum>(Expression<Func<T, object>> expression,
                                                            string propertyNameIsLabelSeperator, int? linesToAppend)
        {
            var propertyMap = GetPropertyMap(expression, propertyNameIsLabelSeperator, linesToAppend);

            propertyMap.AppliedActions.Add(collection => ((IEnumerable<TEnum>) collection).Aggregate(string.Empty, JoinEnum));

            _properties.Add(propertyMap);


            return propertyMap;
        }

        /// <summary>
        /// Maps the specified expression that is an IEnumerable collection that consists of a Mappable sub type. 
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>        
        /// <returns></returns>
        public IRollingPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapEnumerable<TUnderlyingMappableType, TMap>(expression, null, null, null);
        }


        /// <summary>
        /// Maps the specified expression that is an IEnumerable collection that consists of a Mappable sub type.
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                Func<TUnderlyingMappableType, object> orderBy)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapEnumerable<TUnderlyingMappableType, TMap>(expression, orderBy, null, null);
        }

        /// <summary>
        /// Maps the specified expression that is an IEnumerable collection that consists of a Mappable sub type. Uses the property name as the leading label
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>        
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                string propertyNameIsLabelSeperator)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapEnumerable<TUnderlyingMappableType, TMap>(expression, null, propertyNameIsLabelSeperator, null);
        }

        /// <summary>
        /// Maps the specified expression that is an IEnumerable collection that consists of a Mappable sub type. Uses the property name as the leading label
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                Func<TUnderlyingMappableType, object> orderBy,
                                                                                string propertyNameIsLabelSeperator)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapEnumerable<TUnderlyingMappableType, TMap>(expression, orderBy, propertyNameIsLabelSeperator, null);
        }

        /// <summary>
        /// Maps the specified expression that is an IEnumerable collection that consists of a Mappable sub type. 
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderBy">The order by.</param>        
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                Func<TUnderlyingMappableType, object> orderBy,
                                                                                int? linesToAppend)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapEnumerable<TUnderlyingMappableType, TMap>(expression, orderBy, null, linesToAppend);
        }


        /// <summary>
        /// Maps the specified expression that is an IEnumerable collection that consists of a Mappable sub type. Uses the property name as the leading label
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                Func<TUnderlyingMappableType, object> orderBy,
                                                                                string propertyNameIsLabelSeperator, int? linesToAppend)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            var propertyMap = GetPropertyMap(expression, propertyNameIsLabelSeperator, linesToAppend);

            if (orderBy != null)
                propertyMap.AppliedActions.Add(collection => ((IEnumerable<TUnderlyingMappableType>) collection).OrderBy(orderBy)
                                                                 .Aggregate(string.Empty, JoinRenderable<TUnderlyingMappableType, TMap>));
            else
                propertyMap.AppliedActions.Add(collection => ((IEnumerable<TUnderlyingMappableType>) collection)
                                                                 .Aggregate(string.Empty, JoinRenderable<TUnderlyingMappableType, TMap>));

            _properties.Add(propertyMap);


            return propertyMap;
        }


        /// <summary>
        /// Maps the specified expression that consists of a Mappable sub type.
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>                        
        /// <returns></returns>
        public IRollingPropertyMap MapRenderable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapRenderable<TUnderlyingMappableType, TMap>(expression, null, null);
        }

        /// <summary>
        /// Maps the specified expression that consists of a Mappable sub type.
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>                
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapRenderable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                int? linesToAppend)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return MapRenderable<TUnderlyingMappableType, TMap>(expression, null, linesToAppend);
        }

        /// <summary>
        /// Maps the specified expression that consists of a Mappable sub type. Uses the property name as the leading label
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>        
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <param name="linesToAppend">The number of lines to append.</param>
        /// <returns></returns>
        public IRollingPropertyMap MapRenderable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                string propertyNameIsLabelSeperator, int? linesToAppend)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            var propertyMap = GetPropertyMap(expression, propertyNameIsLabelSeperator, linesToAppend);

            propertyMap.AppliedActions.Add(renderable => _rollingConverter.Render<TUnderlyingMappableType, TMap>((TUnderlyingMappableType) renderable));


            _properties.Add(propertyMap);


            return propertyMap;
        }

        /// <summary>
        /// Joins the renderable.
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="flattened">The flattened.</param>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        private string JoinRenderable<TUnderlyingMappableType, TMap>(string flattened, TUnderlyingMappableType item)
            where TMap : RollingMap<TUnderlyingMappableType>
        {
            return flattened + _rollingConverter.Render<TUnderlyingMappableType, TMap>(item);
        }

        #endregion

        #region Class Methods

        /// <summary>
        /// Gets the property map.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="propertyNameIsLabelSeperator">The property name is label seperator.</param>
        /// <param name="linesToAppend">The lines to append.</param>
        /// <returns></returns>
        private static RollingPropertyMap GetPropertyMap(Expression<Func<T, object>> expression, string propertyNameIsLabelSeperator,
                                                         int? linesToAppend)
        {
            var propertyInfo = ReflectionHelper.GetProperty(expression);

            return propertyNameIsLabelSeperator == null
                       ? new RollingPropertyMap {PropertyInfo = propertyInfo, LinesToAppend = linesToAppend, DisplayEmptyValue = true}
                       : new RollingPropertyMap
                             {
                                 PropertyInfo = propertyInfo,
                                 LeadingLabel = propertyInfo.Name + propertyNameIsLabelSeperator,
                                 LinesToAppend = linesToAppend,
                                 DisplayEmptyValue = true
                             };
        }

        /// <summary>
        /// Joins the enum.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="flattened">The flattened.</param>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        private static string JoinEnum<TEnum>(string flattened, TEnum item)
        {
            return string.Format("{0}{1}, ", flattened, EnumerationParser.ReadDescription(item));
        }

        #endregion
    }
}
#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ACH.FileGeneration.Converters;
using ACH.Shared;

#endregion

namespace ACH.FileGeneration.FixedLengthGenerator
{
    public class FixedLengthMap<T> : ClassMap<T, IFixedLengthPropertyMap>
    {
        #region Readonly & Static Fields

        private readonly FixedLengthConverter _fixedLengthConverter = new FixedLengthConverter();
        private readonly IList<IFixedLengthPropertyMap> _properties = new List<IFixedLengthPropertyMap>();

        #endregion

        #region Instance Methods

        public override IFixedLengthPropertyMap Map(Expression<Func<T, object>> expression)
        {
            var propertyMap = new FixedLengthPropertyMap
            {
                MaxLength = 20,
                PaddingChar = ' ',
                PaddingTrails = true,
                AppendingLine = false,
                PropertyInfo = ReflectionHelper.GetProperty(expression),
            };

            _properties.Add(propertyMap);

            return propertyMap;
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
                var length = propertyMap.MaxLength;
                if (propertyMap.PaddingTrails)
                    length *= -1;

                var formatSting = "{0:" + length + ":" + propertyMap.PaddingChar + "}";

                var obj = propertyMap.PropertyInfo.GetValue(writableObject, null);

                obj = propertyMap.AppliedActions.Aggregate(obj, (current, func) => func(current));

                var stringValue = string.Format(new PaddedStringFormatInfo(), formatSting, obj)
                    .Substring(0, Math.Abs(length));

                if (propertyMap.AppendingLine)
                    sb.AppendLine(stringValue);
                else
                    sb.Append(stringValue);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Maps the enumerable.
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <returns></returns>
        public IFixedLengthPropertyMap MapEnumerable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression,
                                                                                    Func<TUnderlyingMappableType, object> orderBy = null)
            where TMap : FixedLengthMap<TUnderlyingMappableType>
        {
            var propertyMap = GetPropertyMap(expression);

            if (orderBy != null)
                propertyMap.AppliedActions.Add(collection => ((IEnumerable<TUnderlyingMappableType>)collection).OrderBy(orderBy)
                                                                 .Aggregate(string.Empty, JoinRenderable<TUnderlyingMappableType, TMap>));
            else
                propertyMap.AppliedActions.Add(collection => ((IEnumerable<TUnderlyingMappableType>)collection)
                                                                 .Aggregate(string.Empty, JoinRenderable<TUnderlyingMappableType, TMap>));

            _properties.Add(propertyMap);


            return propertyMap;
        }

        /// <summary>
        /// Maps the renderable.
        /// </summary>
        /// <typeparam name="TUnderlyingMappableType">The type of the underlying mappable type.</typeparam>
        /// <typeparam name="TMap">The type of the map.</typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public IFixedLengthPropertyMap MapRenderable<TUnderlyingMappableType, TMap>(Expression<Func<T, object>> expression)
            where TMap : FixedLengthMap<TUnderlyingMappableType>
        {
            var propertyMap = GetPropertyMap(expression);

            propertyMap.AppliedActions.Add(renderable => _fixedLengthConverter.Render<TUnderlyingMappableType, TMap>((TUnderlyingMappableType)renderable));

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
            where TMap : FixedLengthMap<TUnderlyingMappableType>
        {
            return flattened + _fixedLengthConverter.Render<TUnderlyingMappableType, TMap>(item);
        }

        #endregion

        #region Class Methods

        /// <summary>
        /// Gets the property map.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        private static FixedLengthPropertyMap GetPropertyMap(Expression<Func<T, object>> expression)
        {
            var propertyInfo = ReflectionHelper.GetProperty(expression);

            return new FixedLengthPropertyMap
            {
                MaxLength = 20,
                PaddingChar = ' ',
                PaddingTrails = true,
                AppendingLine = false,
                PropertyInfo = propertyInfo,
            };
        }

        #endregion
    }
}
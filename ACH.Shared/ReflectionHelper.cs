#region Using Statements

using System;
using System.Linq.Expressions;
using System.Reflection;

#endregion

namespace ACH.Shared
{
    /// <summary>
    /// This file was created from publically available source included with
    /// the  Fluent NHibernate project http://fluentnhibernate.org/ based on
    /// the work contained in the ReflectionHelper class.    
    /// </summary>
    public static class ReflectionHelper
    {
        public static PropertyInfo GetProperty<TModel>(Expression<Func<TModel, object>> expression)
        {
            //I don't think this level of complexity is needed for simple reflection.
            //var isExpressionOfDynamicComponent = expression.ToString().Contains("get_Item");

            //if (isExpressionOfDynamicComponent)
            //    return GetDynamicComponentProperty(expression);

            var memberExpression = GetMemberExpression(expression);

            return (PropertyInfo) memberExpression.Member;
        }

        private static MemberExpression GetMemberExpression<TModel, T>(Expression<Func<TModel, T>> expression)
        {
            return GetMemberExpression(expression, true);
        }

        private static MemberExpression GetMemberExpression<TModel, T>(Expression<Func<TModel, T>> expression,
                                                                       bool enforceCheck)
        {
            MemberExpression memberExpression = null;

            switch (expression.Body.NodeType)
            {
                case ExpressionType.Convert:
                    {
                        var body = (UnaryExpression) expression.Body;
                        memberExpression = body.Operand as MemberExpression;
                    }
                    break;
                case ExpressionType.MemberAccess:
                    memberExpression = expression.Body as MemberExpression;
                    break;
            }

            if (enforceCheck && memberExpression == null)
            {
                throw new ArgumentException("Not a member access", "expression");
            }

            return memberExpression;
        }
    }
}
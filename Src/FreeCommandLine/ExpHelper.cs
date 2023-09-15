using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;

namespace FreeCommandLine
{
    /// <summary>
    /// 表达式帮助类
    /// </summary>
    public static class ExpHelper
    {
        public static IReadOnlyDictionary<string, Delegate> ResoleToProp([NotNull] Type type)
        {
            //获取所有属性
            PropertyInfo[] propertyArray = type.GetProperties();

            //根据属性创建委托
            Dictionary<string, Delegate> resoleDict = new();
            ParameterExpression objParam = Expression.Parameter(type, "obj");
            foreach(PropertyInfo prop in propertyArray)
            {
                // 创建属性值参数
                ParameterExpression propertyValueParam = Expression.Parameter(prop.PropertyType, "propertyValue");

                // 创建赋值操作符
                BinaryExpression assignOperator = Expression.Assign(
                    Expression.PropertyOrField(objParam, prop.Name),
                    propertyValueParam
                );

                // 创建Lambda表达式
                LambdaExpression lamdba = Expression.Lambda(assignOperator, objParam, propertyValueParam);

                // 编译表达式并添加到字典
                resoleDict.Add(prop.Name, lamdba.Compile());
            }

            return resoleDict;
        }
    }
}
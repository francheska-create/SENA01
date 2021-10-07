using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TheoryCustomAttributeTestProject.DataAttribute
{

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class CsvDataAttribute : Xunit.Sdk.DataAttribute
    {

        private readonly string _fileName;

        public CsvDataAttribute(string fileName)
        {
            _fileName = fileName;
        }
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var pars = testMethod.GetParameters();
            var parameterTypes = pars.Select(parameterTypes => parameterTypes.ParameterType).ToArray();
            using var csvFile = new StreamReader(_fileName);
            string line;
            while ((line = csvFile.ReadLine()) != null)
            {
                var row = line.Split(',');
                yield return ConvertParameters(row, parameterTypes);
            }
        }
        private object[] ConvertParameters(IReadOnlyList<object> values, IReadOnlyList<Type> parameterTypes)
        {
            var result = new object[parameterTypes.Count];
            for (var idx = 0; idx < parameterTypes.Count; idx++)
            {
                result[idx] = ConvertParameters(values[idx], parameterTypes[idx]);
            }
            return result;
        }
        private static object ConvertParameters(object parameter, Type parameterType)
        {
            return parameterType == typeof(int) ? Convert.ToInt32(parameter) : parameter;
        }
 }
}

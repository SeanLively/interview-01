using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using CSharp.Attributes;

namespace CSharp.Validation.Factory
{
    public class LicenseValidatorFactory
    {
        private static Dictionary<string, Type> validators = new Dictionary<string, Type>();

        static LicenseValidatorFactory()
        {
            var stateValidators =
              from type in Assembly.GetExecutingAssembly().GetTypes()
              where typeof(ILicenseValidator).IsAssignableFrom(type)
              where !type.IsAbstract && !type.IsInterface

              let attributes = type.GetCustomAttributes(typeof(StateAttribute), false)
              let attribute = attributes[0] as StateAttribute
              select new { type, attribute.StateCode };

            validators = stateValidators.ToDictionary(
                validator => validator.StateCode, 
                validator => validator.type);
        }
        
        public static ILicenseValidator GetLicenseValidator(string stateCode)
        {
            if (stateCode == null || !validators.TryGetValue(stateCode, out var validator))
                return null;

            return Activator.CreateInstance(validator) as ILicenseValidator;
        }
    }
}

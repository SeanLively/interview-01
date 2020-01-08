using System.Text.RegularExpressions;
using CSharp.Attributes;

namespace CSharp.Validation
{
    [State("MS")]
    public class MSLicenseValidator : ILicenseValidator
    {
        public bool Validate(string input)
        {
            return ValidationRegex.IsMatch(input);
        }

        private Regex ValidationRegex = new Regex(@"^\d{9}$");
    }
}

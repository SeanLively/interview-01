using System.Text.RegularExpressions;
using CSharp.Attributes;

namespace CSharp.Validation
{
    [State("NE")]
    public class NELicenseValidator : ILicenseValidator
    {
        public bool Validate(string input)
        {
            return ValidationRegex.IsMatch(input);
        }

        private Regex ValidationRegex = new Regex(@"^[A-Za-z]\d{6,8}$");
    }
}

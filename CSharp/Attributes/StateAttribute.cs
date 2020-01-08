using System;

namespace CSharp.Attributes
{
    public class StateAttribute : Attribute
    {
        public StateAttribute(string stateCode)
        {
            this.StateCode = stateCode;
        }

        public string StateCode { get; set; }
    }
}

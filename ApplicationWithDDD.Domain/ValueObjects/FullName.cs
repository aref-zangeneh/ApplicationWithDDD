using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record FullName
    {
        public string Value { get; set; }
        private int _validLength = 50;
        public FullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FullNameNullOrEmptyException();

            if (value.Length > 50)
                throw new InvalidfullNameLengthException(_validLength);

            Value = value;
        }

        public static implicit operator string(FullName fullName) => fullName.Value;
        public static implicit operator FullName(string fullName) => new FullName(fullName);
    }
}

using ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithDDD.Domain.ValueObjects
{
    public record Biography
    {
        public string Value { get; set; }

        public Biography(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new BiographyNullOrEmptyException();

            if (value.Length > 500)
                throw new InvalidBiographyLengthException();

            Value = value;
        }

        public static implicit operator string(Biography biography) => biography.Value;
        public static implicit operator Biography(string biography) => new Biography(biography);
    }
}

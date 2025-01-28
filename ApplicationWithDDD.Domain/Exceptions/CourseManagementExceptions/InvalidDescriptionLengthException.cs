using ApplicationWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidDescriptionLengthException : CourseManagementException
    {
        public InvalidDescriptionLengthException(int validLength) : base($"Description can not be more than {validLength} characters...")
        {
        }
    }
}

using ApplicationWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidfullNameLengthException : CourseManagementException
    {
        public InvalidfullNameLengthException(int validLength) : base($"FullName can not be more than {validLength} characters...")
        {
        }
    }
}

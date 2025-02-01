using ApplicationWithDDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseAttendeeNotFoundException : CourseManagementException
    {
        public CourseAttendeeNotFoundException() : base("Course attendee not found.")
        {
        }
    }
}

﻿using ApplicationWithDDD.Domain.Entities.CourseManagement;
using ApplicationWithDDD.Domain.Entities.UserManagement;
using ApplicationWithDDD.Domain.Primitives;
using ApplicationWithDDD.Domain.ValueObjects;


namespace ApplicationWithDDD.Domain.Entities.PaymentManagement
{
    public class Invoice : BaseEntity
    {
        private Amount _amount;
        private DateTime _date;
        private BaseId _userId;
        private BaseId _courseId;

        internal Invoice(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId) : base(id)
        {
            _amount = amount;
            _date = date;
            _userId = userId;
            _courseId = courseId;
        }

        public Invoice(BaseId id) : base(id)
        {
            
        }

    }
}

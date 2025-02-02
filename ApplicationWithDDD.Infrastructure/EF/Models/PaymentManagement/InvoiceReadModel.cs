﻿using ApplicationWithDDD.Infrastructure.EF.Models.CourseManagement;
using ApplicationWithDDD.Infrastructure.EF.Models.UserManagement;

namespace ApplicationWithDDD.Infrastructure.EF.Models.PaymentManagement
{
    public class InvoiceReadModel : BaseReadModel
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public UserReadModel User { get; set; }
        public Guid CourseId { get; set; }
        public CourseReadModel Course { get; set; }
    }
}

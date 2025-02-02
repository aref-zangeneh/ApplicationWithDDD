using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationWithDDD.Domain.ValueObjects;

namespace ApplicationWithDDD.Application.Services
{
    public interface IUserReadModelService
    {
        Task<bool> IsUserExistsByEmail(Email email);
    }
}

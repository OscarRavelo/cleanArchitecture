using Cebolla.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cebolla.Domain.Interfaces
{
    public interface IUserService
    {
        IQueryable<User> Get();
        void Create(User user);
    }
}

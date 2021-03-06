using Cebolla.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cebolla.Infraestructure.Wrapper
{
    public interface IRepositoryWrapper
    {
         IUserRepository User { get; }
        void Save();
    }
}

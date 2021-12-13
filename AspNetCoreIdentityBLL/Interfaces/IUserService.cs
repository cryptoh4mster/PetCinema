using AspNetCoreIdentityBLL.DTO;
using AspNetCoreIdentityBLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreIdentityBLL.Interfaces
{
    public interface IUserService
    {
        Task<OperationDetails> AddUser(CreateUserDTO userDTO);
    }
}

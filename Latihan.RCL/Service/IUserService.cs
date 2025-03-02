using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Latihan.RCL.Entity;

namespace Latihan.RCL.Service
{
    public interface IUserService
    {
        Task<List<User>?> GetAllUserAsync();
        Task<User?> LoginAsync(string username);

    }
}

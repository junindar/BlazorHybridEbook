using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorLogin.Entity;

namespace BlazorLogin.Service
{
    public class UserService: IUserService
    {   
        public async Task<List<User>?> GetAllUserAsync()
        {
            var result = new List<User>()
            {
                new()
                {
                   Username =   "admin",Password="123456",Role="Admin",Nama="Junindar"
                },
                //Sintaks di atas adalah contoh data yang akan diambil dari database.
                //untuk detail dapat dilihat pada project lampiran
                new()
                {
                    Username =   "user1",Password="123456",Role="Normal User",Nama="Arya"
                },
                new()
                {
                    Username =   "user2",Password="123456",Role="Staff",Nama="Syifa"
                },
               
            };

            await Task.Delay(50);
            return result;
        }

        public async Task<User?> LoginAsync(string username)
        {
            User? user = null;
            var lstUser = await GetAllUserAsync();
            if (lstUser != null)
            {
                user = lstUser.FirstOrDefault(x => string.Equals(x.Username,
                    username, StringComparison.OrdinalIgnoreCase));
            }
            return user;
        }
    }
}

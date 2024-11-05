using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IUserResponsitory
    {
        public bool CreateUser(User user);
        public bool UpdateUser(User user);
        public bool DeleteUser(Guid id);
        public List<User> GetAllUser();
        public User GetUserById(Guid id);
        public User GetAccount(string username, string password);
    }
}

using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Responsitory
{
    public class UserResponsitory : IUserResponsitory
    {
        ShopClothesContext _context;
        List<User> user;
        public UserResponsitory()
        {
            _context = new ShopClothesContext();
            user = new List<User>();

        }
        public User GetAccount(string username, string password)
        {
            User account = _context.Users.FirstOrDefault(
            a => a.UserName == username && a.PassWord == password);
            return account;
        }
        public bool CreateUser(User user)
        {
            if (user == null)
            {
                return false;
            }
            user.Id = Guid.NewGuid();
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
            // Cập nhật hoặc lưu trữ dữ liệu ở đây


        }

        public bool DeleteUser(Guid id)
        {
            var idxoa = _context.Users.Find(id);
            _context.Users.Remove(idxoa);
            _context.SaveChanges();
            return true;
        }

        public List<User> GetAllUser()
        {
            return user = _context.Users.ToList();
        }

        public User GetUserById(Guid id)
        {
            return _context.Users.Find(id);
        }

        public bool UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return true;
        }
    }
}

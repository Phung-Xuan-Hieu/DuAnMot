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
    public class RoleResponsitory : IRoleResponsitory
    {
        ShopClothesContext context;

        public RoleResponsitory()
        {
            context = new ShopClothesContext();

        }
        public bool CreateRole(Role role)
        {
            if (role == null) return false;
            role.Id = Guid.NewGuid();

            context.Roles.Add(role);
            context.SaveChanges();
            return true;
        }

        public bool DeleteRole(Guid role)
        {
            if (role == null) return false;
            var ro = context.Roles.FirstOrDefault(c => c.Id == role);

            context.Remove(ro);
            context.SaveChanges();
            return true;
        }

        public List<Role> GetAllRole()
        {
            return context.Roles.ToList();
        }

        public Role GetRoleId(Guid id)
        {
            return context.Roles.Find(id);
        }

        public bool UpdateRole(Role role)
        {
            if (role == null) return false;
            var ro = context.Roles.FirstOrDefault(c => c.Id == role.Id);
            ro.Name = role.Name;
            context.Update(ro);
            context.SaveChanges();
            return true;
        }
    }
}

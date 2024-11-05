using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IRoleResponsitory
    {
        public bool CreateRole(Role role);
        public bool DeleteRole(Guid role);
        public bool UpdateRole(Role role);
        public List<Role> GetAllRole();
        public Role GetRoleId(Guid id);
    }
}

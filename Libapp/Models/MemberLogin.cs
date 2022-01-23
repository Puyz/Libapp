using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libapp.Models
{
    public class MemberLogin : Member
    {
        public int loginID;
        public string password;
        public int authority;
    }
}

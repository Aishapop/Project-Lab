using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class User
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        protected string password { get; set; }
        public string email { get; set; }
    }
}

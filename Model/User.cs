using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
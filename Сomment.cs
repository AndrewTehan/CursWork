using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Сomment
    {
        public int СommentId { get; set; }
        public int IdUser { get; set; }
        public int MediaId { get; set; }
        public string Text { get; set; }
    }
}
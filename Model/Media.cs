using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public class Media
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public int Veiw { get; set; }
        public int Like { get; set; }
        public string Type { get; set; }
        public byte[] ImageBytes { get; set; }
        public Discription Discription { get; set; }
    }
}
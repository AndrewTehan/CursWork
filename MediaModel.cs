using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class MediaModel
    {
        public static ProductsModel GetInstance()
        {
            return instance.Value;
        }
    }
}
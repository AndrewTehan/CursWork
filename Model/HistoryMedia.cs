using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace course_work
{
    public class HistoryMedia
    {
        public int HistoryMediaId { get; set; }
        public string NameUser { get; set; }
        public int IdMedia { get; set; }

        public string Title
        {
            get
            {
                using (ApplicationContext db = new ApplicationContext())
                    return db.Medias.First(x => x.Id == IdMedia).Title;
            }
        }

        public BitmapImage Image
        {
            get
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    byte[] array = db.Medias.First(x => x.Id == IdMedia).ImageBytes;

                    using (var ms = new System.IO.MemoryStream(array))
                    {
                        var image = new BitmapImage();
                        image.BeginInit();
                        image.CacheOption = BitmapCacheOption.OnLoad; // here
                        image.StreamSource = ms;
                        image.EndInit();
                        return image;
                    }
                }
            }
        }
    }
}
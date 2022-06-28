using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HamXuLy
    {
        //ảnh -> byte[]
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //Chuyển từ byte[] sang Image
        public static Image ByArrayToImage(byte[] b)
        {
            MemoryStream mmStream = new MemoryStream(b);
            return Image.FromStream(mmStream);
        }
    }
}

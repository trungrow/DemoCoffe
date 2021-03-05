using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCoffe.Helper
{
    public class FileHelepr
    {
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Bitmap ByteToImage(byte[] blod)
        {
            if (blod == null)
                return new Bitmap(Properties.Resources.user);

            MemoryStream memoryStream = new MemoryStream();
            byte[] pdata = blod;
            memoryStream.Write(pdata, 0, Convert.ToInt32(pdata.Length));
            var bm = new Bitmap(memoryStream, false);
            memoryStream.Dispose();

            return bm;
        }

    }
}

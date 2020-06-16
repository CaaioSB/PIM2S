using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caiosb.Util
{
    public static class UtilImage
    {
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image ByteToImage(byte[] byteImg)
        {
            using (MemoryStream memstr = new MemoryStream(byteImg))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
    }
}

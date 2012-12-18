using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PerfectPet.Model.Common
{
    public static class ImageTool
    {

        public static Image Image { get; set; }
        public static byte[] Bytes { get; set; }

        static ImageTool()
        {
            
        }

        private static void GetImageFromBytes(byte[] bytes)
        {
            Image result = null;
            var data = bytes;
            var stream = new MemoryStream(data);
            Image = Image.FromStream(stream);
        }

        public static byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,
                                               System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }

    }
}

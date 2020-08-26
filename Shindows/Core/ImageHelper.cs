using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Core
{
    public static class ImageHelper
    {
        /// <summary>
        /// Преобразует картинку в байты
        /// </summary>
        /// <param name="image">картинка</param>
        /// <returns>массив байтов</returns>
        public static byte[] ImageToByties(this Image image)
        {
            byte[] binaryImage = null;
            using (var binImageStream = new MemoryStream())
            {
                image.Save(binImageStream, image.RawFormat);
                binaryImage = binImageStream.ToArray();
            }
            return binaryImage;
        }

        /// <summary>
        /// Преобразует массив байтов в картинку
        /// </summary>
        /// <param name="binImageStream">байты</param>
        /// <returns>картинка</returns>
        public static Image BytiesToImage(this byte[] binImageStream)
        {
            Image image = null;
            using (var stream = new MemoryStream(binImageStream))
            {
                image = Image.FromStream(stream);
            }
            return image;
        }
    }
}

using LeeDenbighsInteractiveCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LeeDenbighsInteractiveCV.Services
{
    public class ImageService
    {
        public static async Task<ImageSource> GetRemoteImage(string source)
        {
            ImageSource imageSource;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var stream = await client.GetStreamAsync(source);

                    // Create a BitmapImage from the stream.
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = stream;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();

                    imageSource = bitmapImage;
                }
                catch (Exception ex)
                {
                    return null;
                    throw;
                }
            }

            return imageSource;
        }
    }
}

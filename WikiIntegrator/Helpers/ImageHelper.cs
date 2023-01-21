using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Tweetinvi;
using Tweetinvi.Models;

namespace WikiIntegrator.Helpers
{
    public static class ImageHelper
    {
        public static bool isValidate(string imageUrl)
        {
            if (imageUrl.Contains(".jpg"))
                return true;
            else if (imageUrl.Contains(".png"))
                return true;

            return false;
        }
        public static IMedia DownloadImage(string imageUrl)
        {
            byte[] imageBytes;
            using (WebClient webClient = new WebClient())
            {
                imageBytes = webClient.DownloadData(imageUrl);
            }

            IMedia media = Upload.UploadBinary(imageBytes);

            return media;
        }
    }
}

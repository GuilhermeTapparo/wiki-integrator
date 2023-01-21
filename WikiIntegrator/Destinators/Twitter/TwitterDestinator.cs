using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace WikiIntegrator.Destinators.Twitter
{
    public class TwitterDestinator : IDestinator
    {
        public TwitterDestinator()
        {
            Auth.SetUserCredentials(
                EnvironmentConfig.Twitter.ConsumerKey,
                EnvironmentConfig.Twitter.ConsumerKeySecret,
                EnvironmentConfig.Twitter.AccessToken,
                EnvironmentConfig.Twitter.AccessTokenSecret);
        }

        public void Send(string message, IMedia media)
        {
                var optionalParameters = new PublishTweetOptionalParameters
                {
                    Medias = new List<IMedia> { media }
                };

                Tweet.PublishTweet(message, optionalParameters);
        }
    }
}

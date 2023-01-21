using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;

namespace WikiIntegrator.Destinators
{
    public interface IDestinator
    {
        void Send(string message, IMedia media);
    }
}

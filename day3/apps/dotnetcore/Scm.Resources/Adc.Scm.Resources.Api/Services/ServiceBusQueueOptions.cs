using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adc.Scm.Resources.Api.Services
{
    public class ServiceBusQueueOptions
    {
        public string ThumbnailQueueConnectionString { get; set; }
        public string ImageContainer { get; set; }
        public string ThumbnailContainer { get; set; }
    }
}

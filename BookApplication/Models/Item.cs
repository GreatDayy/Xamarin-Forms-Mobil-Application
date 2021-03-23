using System;
using System.Collections.Generic;
using System.Text;

namespace BookApplication.Models
{
    public class Item
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
        
    }
}

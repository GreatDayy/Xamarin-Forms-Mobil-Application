using System;
using System.Collections.Generic;
using System.Text;

namespace BookApplication.Models
{
    public class VolumeInfo
    {
        public string title { get; set; }
        public List<string> authors { get; set; }
        public ImageLinks imageLinks { get; set; }
        public string language { get; set; }
        public string previewLink { get; set; }
        public string infoLink { get; set; }
        public string canonicalVolumeLink { get; set; }
        public string subtitle { get; set; }
        public string description { get; set; }

        public int? pageCount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BookApplication.Models
{
   public class Root
    {
        
            public string kind { get; set; }
            public int totalItems { get; set; }
            public ObservableCollection<Item> items { get; set; }
    }
}

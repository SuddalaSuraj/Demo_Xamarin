using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_App.Models
{
    class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public ContactGroup(string title)
        {
            Title = title;
        }
    }
}

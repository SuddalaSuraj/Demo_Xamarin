using Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup ("S"){
                        new Contact{Name = "Suraj", Status = "Busy In Work", ImageUrl = "http://placehold.jp/100x100.png" },
                        new Contact{Name = "Sunny", Status = "Hey Let's Talk" , ImageUrl = "http://placehold.jp/100x100.png"}
                },

                new ContactGroup("N"){
                        new Contact { Name = "Niraj", Status = "I'm Free", ImageUrl = "http://placehold.jp/100x100.png" }
                }  
            };

        }
    }
}
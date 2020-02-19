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
	public partial class GalleryPage : ContentPage
	{
        public int count = 0;
        string[] m_imageSources = {
                "https://homepages.cae.wisc.edu/~ece533/images/airplane.png",
                "https://homepages.cae.wisc.edu/~ece533/images/arctichare.png",
                "https://homepages.cae.wisc.edu/~ece533/images/baboon.png",
                "https://homepages.cae.wisc.edu/~ece533/images/barbara.png",
                "https://homepages.cae.wisc.edu/~ece533/images/boat.png",
                "https://homepages.cae.wisc.edu/~ece533/images/cat.png",
                "https://homepages.cae.wisc.edu/~ece533/images/fruits.png",
                "https://homepages.cae.wisc.edu/~ece533/images/frymire.png",
                "https://homepages.cae.wisc.edu/~ece533/images/girl.png",
                "https://homepages.cae.wisc.edu/~ece533/images/goldhill.png",
                "https://homepages.cae.wisc.edu/~ece533/images/lena.png",
                "https://homepages.cae.wisc.edu/~ece533/images/monarch.png"
        };
		public GalleryPage ()
		{
			InitializeComponent ();
            setImageSource(0);
		}
        private void setImageSource(int _count)
        {
            var imageSource = new UriImageSource { Uri = new Uri(m_imageSources[_count])};
            imageSource.CachingEnabled = false;
            load_image.Source = imageSource;
        }

        private void Prev_Clicked(object sender, EventArgs e)
        {
            if(count == 0)
            {
                count = 12;
            }
            count--;
            setImageSource(count);
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if(count == 12)
            {
                count = -1;
            }
            count++;
            setImageSource(count);
        }
    }
}
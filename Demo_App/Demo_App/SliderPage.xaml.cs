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
	public partial class SliderPage : ContentPage
	{
        string[] m_quotes = {"Quote_1","Quote_2","Quote_3","Quote_4","Quote_5","Quote_6","Quote_7","Quote_8","Quote_9","Quote_10","Quote_11","Quote_12"};
        int m_currentQuote = 0;

        public SliderPage ()
		{
			InitializeComponent ();
            quote_show.Text = m_quotes[m_currentQuote];
		}

        private void Change_Quote(object sender, EventArgs e)
        {
            m_currentQuote = (m_currentQuote + 1) % 12;
            quote_show.Text = m_quotes[m_currentQuote];
        }
    }
}
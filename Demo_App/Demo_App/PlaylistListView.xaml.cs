using Demo_App.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistListView : ContentPage
	{
		public PlaylistListView ()
		{
            BindingContext = new PlaylistsViewModel();
			InitializeComponent ();
        }

        private void On_AddPlaylist(object sender, EventArgs e)
        {
            (BindingContext as PlaylistsViewModel).AddPlaylist();
        }

        private void On_SelectedPlaylist(object sender, SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as PlaylistViewModel);
        }
    }
}
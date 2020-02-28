using Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demo_App.ViewModels
{
    class PlaylistsViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> PlayLists { get; set; } = new ObservableCollection<PlaylistViewModel>();

        private PlaylistViewModel _selectedPlaylist;

        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlaylist; }
            set { SetValue(ref _selectedPlaylist,value); }
        }
        
        public void AddPlaylist()
        {
            string m_newPlaylist = "Playlist " + (PlayLists.Count+1);
            PlayLists.Add(new PlaylistViewModel { Title = m_newPlaylist });
        }

        public void SelectPlaylist(PlaylistViewModel _playlist)
        {
            if (_playlist == null)
                return;
            _playlist.IsFavorite = !_playlist.IsFavorite;
            SelectedPlaylist = null;
        }
    }
}

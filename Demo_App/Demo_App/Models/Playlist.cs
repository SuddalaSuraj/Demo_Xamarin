using Demo_App.ViewModels;

namespace Demo_App.Models
{
    class Playlist : BaseViewModel
    {
        public string Title { get; set; }
        public bool IsFavorite { get; set; }
    }
}

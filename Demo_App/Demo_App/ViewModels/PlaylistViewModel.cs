using System.Drawing;

namespace Demo_App.ViewModels
{
    class PlaylistViewModel : BaseViewModel
    {
        private bool _isFav;

        public string Title { get; set; }

        public bool IsFavorite
        {
            get { return _isFav; }
            set
            {
                SetValue(ref _isFav, value);
                OnPropertyChanged(nameof(Color));
            }
        }
        public Color Color { get { return IsFavorite ? Color.Green : Color.Red; } }
    }
}

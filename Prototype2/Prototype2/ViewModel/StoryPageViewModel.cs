using Prototype2.Model;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.ObjectModel;

using System.Collections.Generic;
using System.Text;

namespace Prototype2.ViewModel
{
    public class StoryPageViewModel : ViewModelBase
    {
        private StoryInfo _character;
        private ObservableCollection<StoryInfo> _characterItems;
        public ObservableCollection<StoryInfo> CharacterItems
        {
            get { return _characterItems; }
            set { SetProperty(ref _characterItems, value); }

        }
        private DelegateCommand<StoryInfo> _dragCharacterCommand;
  
    

       
        public StoryPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "StoryMaker";
        }

    }
}

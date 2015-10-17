using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System.Collections.ObjectModel;
using UWP_PrismUnity_ComboBox_Sample.Models;
using UWP_PrismUnity_ComboBox_Sample.Services;

namespace UWP_PrismUnity_ComboBox_Sample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDataRepository _dataRepository;

        public MainPageViewModel(IDataRepository dataRepository, INavigationService navService)
        {
            _dataRepository = dataRepository;
            SelectedIndex = 1;
        }

        public ObservableCollection<PageThemeItem> ThemeItems
        {
            get { return _dataRepository.GetComboBoxItems(); }
        }

        private Windows.UI.Xaml.ElementTheme _pageTheme;
        public Windows.UI.Xaml.ElementTheme PageTheme
        {
            get { return _pageTheme; }
            set { SetProperty(ref _pageTheme, value); }
        }


        private int _selectedIndex;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { SetProperty(ref _selectedIndex, value); }
        }


        private PageThemeItem _selectedTheme;
        public PageThemeItem SelectedTheme
        {
            get { return _selectedTheme; }
            set
            {
                PageTheme = value.ThemeContent;
                _selectedTheme = value;
            }
        }

    }
}

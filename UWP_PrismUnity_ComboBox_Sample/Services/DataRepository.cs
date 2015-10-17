using System.Collections.ObjectModel;
using UWP_PrismUnity_ComboBox_Sample.Models;

namespace UWP_PrismUnity_ComboBox_Sample.Services
{
    public class DataRepository : IDataRepository
    {

        public ObservableCollection<PageThemeItem> GetComboBoxItems()
        {
            return new ObservableCollection<PageThemeItem>
            {
                new PageThemeItem() { ThemeContent = Windows.UI.Xaml.ElementTheme.Light, ThemeName = "Light" },
                new PageThemeItem() { ThemeContent = Windows.UI.Xaml.ElementTheme.Dark, ThemeName = "Dark" }
            };
        }
    }
}

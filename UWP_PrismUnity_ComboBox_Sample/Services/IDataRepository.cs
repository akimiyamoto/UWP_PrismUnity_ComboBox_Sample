using System.Collections.ObjectModel;
using UWP_PrismUnity_ComboBox_Sample.Models;

namespace UWP_PrismUnity_ComboBox_Sample.Services
{
    public interface IDataRepository
    {
        ObservableCollection<PageThemeItem> GetComboBoxItems();
    }
}

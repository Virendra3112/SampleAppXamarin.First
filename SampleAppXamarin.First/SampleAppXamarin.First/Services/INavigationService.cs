using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAppXamarin.First.Services
{
    public interface INavigationService
    {
        string CurrentPageKey { get; }
        void GoBack();
        void NavigateTo(string pageKey);
        void NavigateTo(string pageKey, object parameter);
        void PopToRoot();
        void HideDrawerMenu();
    }
}

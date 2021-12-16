using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAppXamarin.First.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Dictionary<string, Type> _pageKeyDictionary;
        public NavigationService()
        {
            _pageKeyDictionary = new Dictionary<string, Type>();
        }
        public void Configure(string pageKey, Type pageType)
        {
            lock (_pageKeyDictionary)
            {
                if (_pageKeyDictionary.ContainsKey(pageKey))
                {
                    _pageKeyDictionary[pageKey] = pageType;
                }
                else
                {
                    _pageKeyDictionary.Add(pageKey, pageType);
                }
            }
        }

        public string CurrentPageKey { get; set; }

        public void GoBack()
        {
            
        }

        public void HideDrawerMenu()
        {
            
        }

        public void NavigateTo(string pageKey)
        {
            
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            
        }

        public void PopToRoot()
        {
           
        }
    }
}

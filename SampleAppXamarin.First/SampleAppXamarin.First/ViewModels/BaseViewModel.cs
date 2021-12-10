using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleAppXamarin.First.ViewModels
{
    public class BaseViewModel : IDisposable
    {
        bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                ShowLoading(value);
                RaisePropertyChanged();
            }
        }

        private void ShowLoading(bool value)
        {
            //try
            //{
            //    if (value)
            //        Device.BeginInvokeOnMainThread(() =>
            //        {
            //            Acr.UserDialogs.UserDialogs.Instance.ShowLoading("Loading...", Acr.UserDialogs.MaskType.Black);
            //        });

            //    else
            //        Device.BeginInvokeOnMainThread(() =>
            //        {
            //            Acr.UserDialogs.UserDialogs.Instance.HideLoading();
            //        });
            //}
            //catch (Exception ex)
            //{
            //}
        }


        #region INotifyPropertyChanged implementation

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler IsActiveChanged;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword


        protected new void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        #endregion
        #region IDisposable implementation

        public virtual void Dispose()
        {
        }

        #endregion

    }
}

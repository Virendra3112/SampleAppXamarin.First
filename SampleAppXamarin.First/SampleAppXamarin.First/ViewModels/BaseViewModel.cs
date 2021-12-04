using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleAppXamarin.First.ViewModels
{
    public class BaseViewModel: IDisposable
    {


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

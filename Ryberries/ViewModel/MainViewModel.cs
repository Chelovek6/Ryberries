using Ryberries.DataContext;
using Ryberries.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ryberries.ViewModel
{
    //internal class ViewModelBase : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }

    //    protected virtual void Dispose() { }
    //}
    public class MainViewModel : INotifyPropertyChanged
    {

        public interface IGameViewModel
        {

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void ShowUserControl3()
        {
            LocatorView.CurrentView.UserControl.Content = new UserControl1();
        }
        

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

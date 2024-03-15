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
using GalaSoft.MvvmLight.Command;


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
       // public ICommand ShowUserControl1Command => new RelayCommand(ShowUserControl1);
       //public ICommand ShowUserControl2Command => new RelayCommand(ShowUserControl2);
        public ICommand ShowUserControl3Command => new RelayCommand(ShowUserControl3);
       // public ICommand ShowUserControl4Command => new RelayCommand(ShowUserControl4);
        public ICommand ShowUserControl10Command => new RelayCommand(ShowUserControl10);
        

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ShowUserControl3()
        {
            LocatorView.CurrentView.UserControl.Content = new UserControl1();
        }
        private void ShowUserControl10()
        {
            LocatorView.CurrentView.UserControl.Content = new UsersMainView();
        }

        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

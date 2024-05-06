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
        public ICommand ShowUserControl1Command => new RelayCommand(ShowUserControl1);
      
        public ICommand ShowUserControl3Command => new RelayCommand(ShowUserControl3);
       
        public ICommand ShowUserControl10Command => new RelayCommand(ShowUserControl10);
        public ICommand ShowUserControl2Command => new RelayCommand(ShowUserControl2);
        public ICommand ShowUserControl4Command => new RelayCommand(ShowUserControl4);
        public ICommand ShowUserControl5Command => new RelayCommand(ShowUserControl5);
        public ICommand ShowUserControl6Command => new RelayCommand(ShowUserControl6);
        public ICommand ShowUserControl7Command => new RelayCommand(ShowUserControl7);

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ShowUserControl3()
        {
            LocatorView.CurrentView.UserControl.Content = new UserControl1();
        }
        private void ShowUserControl2()
        {
            LocatorView.CurrentView.UserControl.Content = new StaffMainView();
        }
        private void ShowUserControl4()
        {
            LocatorView.CurrentView.UserControl.Content = new AdminMainView();
        }
        private void ShowUserControl5()
        {
            LocatorView.CurrentView.UserControl.Content = new StuffGoodsView();
        }
        private void ShowUserControl6()
        {
            LocatorView.CurrentView.UserControl.Content = new AdminGoodsView();
        }
        private void ShowUserControl7()
        {
            LocatorView.CurrentView.UserControl.Content = new AdminStaffView();
        }
        private void ShowUserControl10()
        {
            LocatorView.CurrentView.UserControl.Content = new UsersMainView();
        }
        private void ShowUserControl1()
        {
            LocatorView.CurrentView.UserControl.Content = new UserGoodsView();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

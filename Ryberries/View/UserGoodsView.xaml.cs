using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ryberries.Model;
using System.Configuration;
using Ryberries.ViewModel;


namespace Ryberries.View
{
    /// <summary>
    /// Логика взаимодействия для UserGoodsView.xaml
    /// </summary>
    public partial class UserGoodsView : UserControl
    {
        public GoodsViewModel view;


        public UserGoodsView()
        {
            InitializeComponent();
            view = new GoodsViewModel();
            DataContext = view;
            view.LoadGoods();
        }


    }
}

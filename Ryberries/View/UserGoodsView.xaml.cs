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


namespace Ryberries.View
{
    /// <summary>
    /// Логика взаимодействия для UserGoodsView.xaml
    /// </summary>
    public partial class UserGoodsView : UserControl
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable goodsTable;

        public UserGoodsView()
        {
            InitializeComponent();

            // Получаем строку подключения из app.config
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            UserControl_Loaded(null, null);
        }
        private List<Goods> goodsList; // Объявляем goodsList как член класса

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Товары"; // Запрос данных из таблицы Товары
            goodsTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(goodsTable);

                // Создаем список объектов Goods и заполняем его данными из таблицы Товары
                List<Goods> goodsList = new List<Goods>();
                foreach (DataRow row in goodsTable.Rows)
                {
                    goodsList.Add(new Goods(
                        Convert.ToInt32(row["ID_Товара"]),
                        row["Название"].ToString(),
                        Convert.ToInt32(row["ID_Продавца"]),
                        Convert.ToInt32(row["Цена"]),
                        Convert.ToSingle(row["Рейтинг"])
                    ));
                }

                // Устанавливаем источник данных для элемента управления DataGrid
                goodsGrid.ItemsSource = goodsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
            UserControl_Loaded(null, null);
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что goodsList не равен null
            if (goodsList != null)
            {
                // Проверяем, есть ли выбранные элементы
                if (goodsGrid.SelectedItems != null && goodsGrid.SelectedItems.Count > 0)
                {
                    // Создаем список для хранения выбранных элементов
                    List<Goods> selectedGoods = new List<Goods>();

                    // Получаем выбранные элементы и добавляем их в список selectedGoods
                    foreach (var selectedItem in goodsGrid.SelectedItems)
                    {
                        if (selectedItem is Goods selectedGoodsItem)
                        {
                            selectedGoods.Add(selectedGoodsItem);
                        }
                    }

                    // Удаляем выбранные элементы из goodsList
                    foreach (var item in selectedGoods)
                    {
                        goodsList.Remove(item);
                    }

                    // Обновляем источник данных для DataGrid
                    goodsGrid.ItemsSource = null;
                    goodsGrid.ItemsSource = goodsList;

                    // Вызываем метод UpdateDB для синхронизации с базой данных
                    UpdateDB();
                    UserControl_Loaded(null, null);
                }
                else
                {
                    MessageBox.Show("Выберите товары для удаления.");
                }
            }
            else
            {
                MessageBox.Show("Список товаров не инициализирован.");
            }
        }


        private void UpdateDB()
        {
            if (adapter != null && goodsTable != null)
            {
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(goodsTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении базы данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Адаптер или таблица не инициализированы.");
            }
        }
    }
}

using Ryberries.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Ryberries.ViewModel
{
    public class GoodsViewModel
    {
        private string connectionString;
        private SqlDataAdapter adapter;
        private DataTable goodsTable;

        public ObservableCollection<Goods> GoodsList { get; set; }

        public GoodsViewModel()
        {
            // Получаем строку подключения из app.config
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            GoodsList = new ObservableCollection<Goods>(); // Инициализируем коллекцию здесь
            LoadGoods();
        }

        public void LoadGoods()
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

                // Очищаем коллекцию перед добавлением новых данных
                GoodsList.Clear();

                // Создаем список объектов Goods и заполняем его данными из таблицы Товары
                foreach (DataRow row in goodsTable.Rows)
                {
                    GoodsList.Add(new Goods(
                        Convert.ToInt32(row["ID_Товара"]),
                        row["Название"].ToString(),
                        Convert.ToInt32(row["ID_Продавца"]),
                        Convert.ToInt32(row["Цена"]),
                        Convert.ToSingle(row["Рейтинг"])
                    ));
                }
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

        public void UpdateDB()
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


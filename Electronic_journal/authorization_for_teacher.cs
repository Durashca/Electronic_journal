using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Electronic_journal
{
    public partial class authorization_for_teacher : Form
    {
        public authorization_for_teacher()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorization_for_teacher_Load(object sender, EventArgs e)
        {
            // Получаем размер экрана
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Получаем размер формы
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Вычисляем координаты для размещения формы посередине экрана
            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // Устанавливаем позицию формы
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(left, top);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\user\\Desktop\\SQlite\\simplefolks.sqlite");
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("ошибка", "Ошибка");
                throw;
            }
            string login = teacher_login.Text;
            string pass = teacher_password.Text;
            SQLiteDataReader sQLiteDataReader;
            SQLiteCommand sQLiteCommand = con.CreateCommand();
            sQLiteCommand.CommandText = $"SELECT COUNT (*) FROM inmates WHERE first_name = '{login}' and pass = '{pass}' ";

            sQLiteDataReader = sQLiteCommand.ExecuteReader();
            while (sQLiteDataReader.Read())
            {

                if (sQLiteDataReader.GetInt32(0) == 1)
                {
                    profile_teatcher3 profile_Teatcher3 = new profile_teatcher3();
                    profile_Teatcher3.Show();
                    this.Close();
                }
                else { MessageBox.Show("неправильно"); }

            }
            con.Close();

        }
    }
}

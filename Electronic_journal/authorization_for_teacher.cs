using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (teacher_login.Text == "admin" || teacher_login.Text == "admin")
            {
               
                this.Close();
                profile_teatcher3 profile_teacher = new profile_teatcher3();      
                profile_teacher.Show();

            } else
            {
                MessageBox.Show("Проверьте введённые данные", "Ошибка");
            }
            
        }
    }
}

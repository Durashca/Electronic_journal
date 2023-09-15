using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_journal
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            authorization_for_teacher authorization_For_Teacher =  new authorization_for_teacher();
            authorization_For_Teacher.ShowDialog();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorization_for_student authorization_For_Student = new authorization_for_student();
            authorization_For_Student.ShowDialog();

        }

       
        // для того что бы форма появлялась посередине экрана
        private void authorization1_Load(object sender, EventArgs e)
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
    }
}

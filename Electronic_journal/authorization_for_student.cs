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
    public partial class authorization_for_student : Form
    {
        public authorization_for_student()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void authorization_for_student_Load(object sender, EventArgs e)
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

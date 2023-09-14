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
    public partial class authorization1 : Form
    {
        public authorization1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            authorization_for_teacher2 authorization_For_Teacher =  new authorization_for_teacher2();
            authorization_For_Teacher.ShowDialog();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorization_for_student2 authorization_For_Student = new authorization_for_student2();
            authorization_For_Student.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

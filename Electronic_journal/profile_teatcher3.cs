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
    public partial class profile_teatcher3 : Form
    {
        public profile_teatcher3()
        {
            InitializeComponent();
        }

        private void profile_teatcher_Load(object sender, EventArgs e)
        {
            authorization_for_teacher auth_teacher = new authorization_for_teacher();
            auth_teacher.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            this.Hide();
            department.ShowDialog();
            this.Show();
        }

        private void btnCollege_Click(object sender, EventArgs e)
        {
            College college = new College();
            this.Hide();
            college.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

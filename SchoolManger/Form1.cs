using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Teacher_Click(object sender, EventArgs e)
        {
            teacherControl1.Show();
            classRoomControl1.Hide();
        }

        private void B_ClassRoom_Click(object sender, EventArgs e)
        {
            teacherControl1.Hide();
            classRoomControl1.Show();
        }
    }
}

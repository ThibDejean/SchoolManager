using ITI.SchoolManager;
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

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            //School toto = new School();
            //ClassRoom pouet = new ClassRoom();
            //ClassRoom pouet2 = new ClassRoom();

            //toto.SchoolName = "Ecole des ollières";
            //toto.ClassRoomList.Add(pouet);
            //toto.CountClassRoom++;
            //toto.ClassRoomList[0].ClassRoomName = "CP";
            //toto.ClassRoomList[0].NumberOfEmptySeat = 4;
            //toto.ClassRoomList[0].NumberOfStudent = 14;
            //toto.ClassRoomList[0].ClasseRoomTeacher = new Teacher("jeanjako", "délavega", true);

            //toto.ClassRoomList.Add(pouet2);
            //toto.CountClassRoom++;
            //toto.ClassRoomList[1].ClassRoomName = "CE1";
            //toto.ClassRoomList[1].NumberOfEmptySeat = 8;
            //toto.ClassRoomList[1].NumberOfStudent = 18;
            //toto.ClassRoomList[1].ClasseRoomTeacher = new Teacher("juju", "jojo", true);

            //toto.SaveSchool(toto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            School toto = new School();
            toto = toto.LoadSchool();

            this.Text = toto.SchoolName;
        }

        

       
    }
}

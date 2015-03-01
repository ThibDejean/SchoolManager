using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.SchoolManager;

namespace SchoolManger
{
    public partial class ClassRoomControl : UserControl
    {
        public ClassRoomControl()
        {
            InitializeComponent();
        }
        private void ClassRoomControl_Load(object sender, EventArgs e)
        {
            School myschool = new School();
            Teacher myteacher = new Teacher("Jean", "Dupond", true);
            ClassRoom myclassroom = new ClassRoom(5, 18, myteacher, "CP");
            myschool.ClassRoomList.Add(myclassroom);
            ClassRoom test = myschool.ClassRoomList[0];
            DGV_ClassDetails.Rows.Add(test.ClassRoomName, 
                                      test.ClasseRoomTeacher.FirstName +" "+ test.ClasseRoomTeacher.LastName,
                                      test.NumberOfStudent,
                                      test.NumberOfEmptySeat);
        }

        private void DGV_ClassDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

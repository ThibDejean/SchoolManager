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
            School mySchool = new School();
            mySchool = mySchool.LoadSchool();

            for (int i = 0; i < mySchool.ClassRoomList.Count; i++)
            {
                DGV_ClassDetails.Rows.Add(mySchool.ClassRoomList[i].ClassRoomName,
                                          mySchool.ClassRoomList[i].ClasseRoomTeacher.FirstName + " " + mySchool.ClassRoomList[i].ClasseRoomTeacher.LastName,
                                          mySchool.ClassRoomList[i].NumberOfStudent,
                                          mySchool.ClassRoomList[i].NumberOfEmptySeat);
            }



            foreach (DataGridViewColumn column in DGV_ClassDetails.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }



        }

        private void DGV_ClassDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            School mySchool = new School();
            mySchool = mySchool.LoadSchool();

            //e.Columnindex = données à changer et e.RowIndex = classroom 
            if (e.RowIndex != -1)
            {
                if (e.RowIndex <= mySchool.ClassRoomList.Count)
                {
                    if (e.ColumnIndex == 0)
                    {
                        mySchool.ClassRoomList[e.RowIndex].ClassRoomName = DGV_ClassDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    if (e.ColumnIndex == 1)
                    {
                        string name = DGV_ClassDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        string firstname = "";
                        string lastname = "";
                        bool firstnamefinished = false;

                        foreach (char c in name)
                        {
                            if (char.IsWhiteSpace(c))
                            {
                                firstnamefinished = true;
                            }
                            if (!firstnamefinished)
                            {
                                firstname += c.ToString();
                            }
                            else
                            {
                                if (!char.IsWhiteSpace(c))
                                {
                                    lastname += c.ToString();
                                }
                            }
                        }
                        mySchool.ClassRoomList[e.RowIndex].ClasseRoomTeacher.FirstName = firstname;
                        mySchool.ClassRoomList[e.RowIndex].ClasseRoomTeacher.LastName = lastname;

                    }
                    if (e.ColumnIndex == 2)
                    {
                        int num;
                        string value = DGV_ClassDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        bool result = Int32.TryParse(value, out num);
                        if (result)
                        {
                            mySchool.ClassRoomList[e.RowIndex].NumberOfStudent = num;
                        }
                    }
                    if (e.ColumnIndex == 3)
                    {
                        int num;
                        string value = DGV_ClassDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        bool result = Int32.TryParse(value, out num);
                        if (result)
                        {
                            mySchool.ClassRoomList[e.RowIndex].NumberOfEmptySeat = num;
                        }
                    }
                }
                mySchool.SaveSchool(mySchool);
            }
        }

        private void B_CreateNewClass_Click(object sender, EventArgs e)
        {
            string className = TB_ClassName.Text;
            string profName = TB_ProfName.Text;
            string nbStudent = TB_NbStudent.Text.ToString();
            string nbSeat = TB_NbSeat.Text.ToString();

            int num1;
            int num2;
            bool result1 = Int32.TryParse(nbStudent, out num1);
            bool result2 = Int32.TryParse(nbSeat, out num2);

            string firstname = "";
            string lastname = "";
            bool firstnamefinished = false;


            ClassRoom newClassRoom = new ClassRoom();
            newClassRoom.ClassRoomName = className;
            Teacher newTeacher = new Teacher();
            if (result1)
            {
                newClassRoom.NumberOfStudent = num1;
            }
            if (result2)
            {
                newClassRoom.NumberOfEmptySeat = num2;
            }

            foreach (char c in profName)
            {
                if (char.IsWhiteSpace(c))
                {
                    firstnamefinished = true;
                }
                if (!firstnamefinished)
                {
                    firstname += c.ToString();
                }
                else
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        lastname += c.ToString();
                    }
                }
            }

            newTeacher.FirstName = firstname;
            newTeacher.LastName = lastname;
            newTeacher.IsPresent = true;
            newClassRoom.ClasseRoomTeacher = newTeacher;

            School myschool = new School();
            myschool = myschool.LoadSchool();

            myschool.ClassRoomList.Add(newClassRoom);           
            myschool.SaveSchool(myschool);

           DGV_ClassDetails.Rows.Add(myschool.ClassRoomList[myschool.ClassRoomList.Count-1].ClassRoomName,
                                      myschool.ClassRoomList[myschool.ClassRoomList.Count-1].ClasseRoomTeacher.FirstName + " " + myschool.ClassRoomList[myschool.ClassRoomList.Count-1].ClasseRoomTeacher.LastName,
                                      myschool.ClassRoomList[myschool.ClassRoomList.Count-1].NumberOfStudent,
                                      myschool.ClassRoomList[myschool.ClassRoomList.Count-1].NumberOfEmptySeat);

           
        }

        //TODO check that TB are string or int as requested
        # region Activate button when all TB are not empty
        private void TB_ClassName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_ClassName.Text)
                && !String.IsNullOrWhiteSpace(TB_ProfName.Text)
                && !String.IsNullOrWhiteSpace(TB_NbStudent.Text)
                && !String.IsNullOrWhiteSpace(TB_NbSeat.Text))
            {
                B_CreateNewClass.Enabled = true;
            }
        }

        private void TB_ProfName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_ClassName.Text)
                && !String.IsNullOrWhiteSpace(TB_ProfName.Text)
                && !String.IsNullOrWhiteSpace(TB_NbStudent.Text)
                && !String.IsNullOrWhiteSpace(TB_NbSeat.Text))
            {
                B_CreateNewClass.Enabled = true;
            }
        }

        private void TB_NbStudent_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_ClassName.Text)
                && !String.IsNullOrWhiteSpace(TB_ProfName.Text)
                && !String.IsNullOrWhiteSpace(TB_NbStudent.Text)
                && !String.IsNullOrWhiteSpace(TB_NbSeat.Text))
            {
                B_CreateNewClass.Enabled = true;
            }
        }

        private void TB_NbSeat_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TB_ClassName.Text)
               && !String.IsNullOrWhiteSpace(TB_ProfName.Text)
               && !String.IsNullOrWhiteSpace(TB_NbStudent.Text)
               && !String.IsNullOrWhiteSpace(TB_NbSeat.Text))
            {
                B_CreateNewClass.Enabled = true;
            }
        }
        #endregion







    }



}


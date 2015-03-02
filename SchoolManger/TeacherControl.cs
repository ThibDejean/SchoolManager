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
    public partial class TeacherControl : UserControl
    {
        public TeacherControl()
        {
            InitializeComponent();
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            School mySchool = new School();
            mySchool = mySchool.LoadSchool();

            for (int i = 0; i < mySchool.ClassRoomList.Count; i++)
            {
                Teacher toto = new Teacher();
                toto = mySchool.ClassRoomList[i].ClasseRoomTeacher;
                CLB_TeacherList.Items.Add(toto.FirstName + " " + toto.LastName, !toto.IsPresent);
            }
        }

        private void TeacherControl_Leave(object sender, EventArgs e)
        {
            School mySchool = new School();
            mySchool = mySchool.LoadSchool();

            for (int i = 0; i < mySchool.ClassRoomList.Count; i++)
            {
                mySchool.ClassRoomList[i].ClasseRoomTeacher.IsPresent = true;
            }

            foreach (int indexChecked in CLB_TeacherList.CheckedIndices)
            {
                mySchool.ClassRoomList[indexChecked].ClasseRoomTeacher.IsPresent = false;
            }


            mySchool.SaveSchool(mySchool);
        }

        private void B_Dispatch_Click(object sender, EventArgs e)
        {
            School mySchool = new School();
            mySchool = mySchool.LoadSchool();

            List<ClassRoom> classRoomToDispatchList = new List<ClassRoom>();
            int nbOfStudentToMove = 0;
            int nbOfStudentREmaining = 0;
            int nbTotalOfEmptySeat = 0;
            string dispatch = "";
            //ajoute les classes avec prof manquants à la liste 
            foreach (int indexChecked in CLB_TeacherList.CheckedIndices)
            {
                classRoomToDispatchList.Add(mySchool.ClassRoomList[indexChecked]);
            }
            //donne le nb de places libres total
            IEnumerable<ClassRoom> requete = from cr in mySchool.ClassRoomList
                                             where cr.ClasseRoomTeacher.IsPresent == true
                                             select cr;
            IEnumerable<ClassRoom> requeteAbs = from cr in mySchool.ClassRoomList
                                                where cr.ClasseRoomTeacher.IsPresent == false
                                                select cr;

            foreach (ClassRoom cr in requete)
            {
                nbTotalOfEmptySeat += cr.NumberOfEmptySeat;
            }

            foreach (ClassRoom cr in requeteAbs)
            {
                nbOfStudentREmaining += cr.NumberOfStudent;
            }

            if (nbOfStudentREmaining > nbTotalOfEmptySeat)
            {
                RTB_Dispatch.Text = " Il n'y a pas assez de places pour tous les élèves";
            }
            else
            {

                while (nbOfStudentREmaining > 0)
                {
                foreach (ClassRoom crAbs in requeteAbs)
                {
                    nbOfStudentToMove = crAbs.NumberOfStudent;
                    
                        foreach (ClassRoom cr in requete)
                        {
                            if(cr.NumberOfEmptySeat > 0)
                            {
                                if (cr.NumberOfEmptySeat <= crAbs.NumberOfStudent)
                                {
                                    //Marche si tout les étudiants ne vont pas dans une seule classe
                                    nbOfStudentToMove -= cr.NumberOfEmptySeat;
                                    nbOfStudentREmaining -= cr.NumberOfEmptySeat;
                                    // cr.NumberOfEmptySeat -= nbOfStudentToMove;
                                    dispatch += Environment.NewLine + cr.NumberOfEmptySeat.ToString() + "élèves de la classe " + crAbs.ClassRoomName
                                                                         + " iront dans la classe : " + cr.ClassRoomName;
                                }
                                if (cr.NumberOfStudent > crAbs.NumberOfStudent)
                                {
                                    nbOfStudentREmaining -= nbOfStudentToMove;
                                    dispatch += Environment.NewLine + nbOfStudentToMove.ToString() + "élèves de la classe " + crAbs.ClassRoomName
                                                                         + " iront dans la classe : " + cr.ClassRoomName;
                                    cr.NumberOfEmptySeat -= nbOfStudentToMove;
                                }
                                
                            }
                        }
                    }
                    RTB_Dispatch.Text = dispatch;
                }
            }
        }

        //parcours les classes ou le prof est absent
        //for (int j = 0; j < classRoomToDispatchList.Count; j++)
        //{                
        //    if (nbOfStudentREmaining > nbTotalOfEmptySeat)
        //    {
        //        RTB_Dispatch.Text = " Il n'y a pas assez de places pour tous les élèves";
        //        break;
        //    }
        //    //tant qu'il y a des élèves a dispatch
        //    while (nbOfStudentREmaining > 0)
        //    {
        //        //parcours toutes les classes
        //        for (int i = 0; i < mySchool.ClassRoomList.Count; i++)
        //        {
        //            //on check que les deux classes ne sont pas les mêmes
        //            if (mySchool.ClassRoomList[i] != classRoomToDispatchList[j])
        //            {
        //                nbOfStudentToMove = mySchool.ClassRoomList[i].NumberOfEmptySeat;
        //                if (nbOfStudentREmaining - nbOfStudentToMove < 0)
        //                {
        //                    dispatch += Environment.NewLine + nbOfStudentREmaining.ToString() + "élèves de la classe " + classRoomToDispatchList[j].ClassRoomName
        //                                                         + " iront dans la classe : " + mySchool.ClassRoomList[i].ClassRoomName;
        //                    nbOfStudentREmaining -= nbOfStudentToMove;
        //                }
        //                else
        //                {
        //                    nbOfStudentREmaining -= nbOfStudentToMove;
        //                    dispatch += Environment.NewLine + nbOfStudentToMove.ToString() + "élèves de la classe " + classRoomToDispatchList[j].ClassRoomName
        //                                                         + " iront dans la classe : " + mySchool.ClassRoomList[i].ClassRoomName;
        //                }
        //                //création du message de type : X élèves de classe abs iront dans telle classe
        //                // test si nb eleve a move est plus grand que nb de place totale, dire que pas possible
        //                // 
        //            }
        //        }
        //    }
        //    RTB_Dispatch.Text = dispatch;
        //}



    }


}


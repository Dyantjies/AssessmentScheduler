/* Subject code: ONT2000
 * Semester 1: Assignment 1
 * 
 * //Group Members
 * ******************************
 * 
 * Name: Thulani
 * Surname: Dyantjies
 * Student number: 217669840
 * ******************************
 * ------------------------------
 * Name: Bokang
 * Surname: Ngoetjana
 * Student number: 220689725
 * ------------------------------
 * Name: Amanda
 * Surname: Ngalo
 * Student number: 219314861
 * ------------------------------
 * Name: Lizwi
 * Surname: Gwaza
 * Student number: 220004358
 * ------------------------------
 * 
 *  
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Semester_1_Assignment_1
{
    public partial class Form7 : Form
    {
        static int assessmentCode = 548748;

        public string v;
        public string v1;

        public Form7(string d,string d1)
        {
            InitializeComponent();
            v = d;
            v1 = d1;
        }

        public Form7()
        {
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
           
            txtAssessmentCode.Text = assessmentCode.ToString();
            txtAssessmentCode.Enabled = false;
            cmbAssessmentType.Items.Add("Semester Test");
            cmbAssessmentType.Items.Add("Exam");
            cmbAssessmentType.Items.Add("Assingment");
            cmbAssessmentType.Items.Add("Practical");
            cmbAssessmentType.Items.Add("June Assessment");

            StreamReader myReader = new StreamReader("Module.txt", true);
            {
                string line = "";
                string[] fields;

                while ((line = myReader.ReadLine()) != null)
                {
                    fields = line.Split('#');

                    cmbModule.Items.Add(fields[1]);
                }
                
                myReader.Close();
            }

        }

        private void cmbAssessmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

            assessmentCode = assessmentCode + 1;
            txtAssessmentCode.Text = assessmentCode.ToString();
            txtAssessmentCode.Enabled = false;


            StreamReader mReader = new StreamReader("Module.txt",true);
            string line = "";
            string[] fields;

            if ((line = mReader.ReadLine()) != null)
            {
                fields = line.Split('#');


                lstAssessment.Items.Add(txtAssessmentCode.Text +"\t\t|"+ cmbModule.Text + "\t\t|" + txtAssessmentDesc.Text + "\t\t|" + dtpAssessmentDate.Text + "\t\t|" + cmbAssessmentType.Text);

                StreamWriter awriter = new StreamWriter("Assessment.txt", true);
                {

                    awriter.WriteLine(txtAssessmentCode.Text + "#" + cmbModule.Text + "#" + txtAssessmentDesc.Text + "#" + dtpAssessmentDate.Text + "#" + cmbAssessmentType.Text);
                    awriter.Close();
                }

            }
            mReader.Close();
             
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(v,v1);
            form3.Show();
            Visible = false;
        }
    }
}

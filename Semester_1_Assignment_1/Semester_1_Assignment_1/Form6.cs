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
    public partial class Form6 : Form
    {
        static int moduleCode = 54879;

        public string v;
        public string v1;

        public Form6(string f,string f1)
        {
            InitializeComponent();
            v = f;
            v1 = f1;
        }

        public Form6()
        {
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
           
            txtBoxModuleCode.Text = moduleCode.ToString();
            txtBoxModuleCode.Enabled = false;
            
            StreamReader mreader = new StreamReader("Lecturer.txt", true);
            {
                string line = "";
                string[] fileds;
                while ((line = mreader.ReadLine()) != null)
                {
                    fileds = line.Split('#');
                    cmbBoxLecturers.Items.Add(fileds[1] + "\t" + fileds[2]);
                }
                mreader.Close();
            }
           
            
        }

        private void btnGoToLanding_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(v,v1);
            form3.Show();
            Visible = false;

        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            moduleCode = moduleCode + 1;
            txtBoxModuleCode.Text = moduleCode.ToString();
            txtBoxModuleCode.Enabled = false;


            StreamWriter mwriter = new StreamWriter("Module.txt", true);
            {
                mwriter.WriteLine(txtBoxModuleCode.Text + "#" + txtBoxModuleDesc.Text + "#" + cmbBoxLecturers.Text);
                mwriter.Close();
            }
        }

        private void btnListModule_Click(object sender, EventArgs e)
        {
            StreamReader mreader = new StreamReader("Module.txt", true);
            {
                string line = "";
                string[] fields;

                while ((line = mreader.ReadLine()) != null)
                {
                    fields = line.Split('#');
                    lstModules.Items.Add(fields[0] + "\t" + fields[1] + "\t" + fields[2]);
                }
                mreader.Close();
            }
            

            

        }

        private void cmbBoxLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

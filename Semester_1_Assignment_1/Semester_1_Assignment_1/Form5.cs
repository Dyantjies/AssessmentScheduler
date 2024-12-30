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
    public partial class Form5 : Form
    {
        static int lecturerCode = 8787988;
        public string v;
        public string v1;
        
        public Form5(string x,string x1)
        {
            InitializeComponent();
            v = x;
            v1 = x1;
        }

        public Form5()
        {
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
           
            txtBoxLecturerCode.Text = lecturerCode.ToString();
            txtBoxLecturerCode.Enabled = false;
           
        }

        private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecturerCode = lecturerCode + 1;
            txtBoxLecturerCode.Text = lecturerCode.ToString();
            txtBoxLecturerCode.Enabled = false;

            StreamWriter lwriter = new StreamWriter("Lecturer.txt", true);
            {
                lwriter.WriteLine(txtBoxLecturerCode.Text + "#" + txtBoxName.Text + "#" + txtBoxSurname.Text);
                lwriter.Close();
            }
        }

        private void leaveLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                    Form3 form3 = new Form3(v,v1);
                    form3.Show();
                    Visible = false;
                
            
        }

        private void listLecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader lreader = new StreamReader("Lecturer.txt", true);
            {
                string line = "";
                string[] fields;
                while ((line = lreader.ReadLine()) != null)
                {
                    fields = line.Split('#');
                    lstLecturers.Items.Add(fields[0] + "\t\t" + fields[1] + "\t" + fields[2]);
                    
                }
                lreader.Close();
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

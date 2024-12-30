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
    public partial class Form8 : Form
    {
        public string v;
        public string v1;

        public Form8(string b,string b1)
        {
            InitializeComponent();
            v = b;
            v1 = b1;
        }

        public Form8()
        {
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnReturnToLanding_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(v,v1);
            form3.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader vreader = new StreamReader("Assessment.txt", true);
            {
                string line = "";
                string[] fields;
              

                while ((line = vreader.ReadLine()) != null)
                {
                    fields = line.Split('#');


                    if (textBox1.Text == fields[0] || textBox1.Text == fields[1] || textBox1.Text == fields[2])
                    {
                        lstBoxModules.Items.Add(fields[0] + "\t" + fields[1] + "\t" + fields[2] + "\t" + fields[3] + "\t" + fields[4]);
                        lblTryAgain.Text = "Assessment/s below.";
                    }
                    else if (textBox1.Text != fields[0] || textBox1.Text != fields[1] || textBox1.Text != fields[2])
                    {
                        lblTryAgain.Text = "Assessment not found,please try again.";
                    }


                }
                    vreader.Close();
                
            }
        }
    }
}

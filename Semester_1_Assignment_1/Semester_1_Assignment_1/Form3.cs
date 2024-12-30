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
    public partial class Form3 : Form
    {

        public Form3(string v,string v1)
        {
            InitializeComponent();
            linklblWelcome.Text = "Welcome" + "("+ v +","+ "\t"+ v1 + ")";
        }

        public Form3()
        {
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void Form3_Load(object sender, EventArgs e)
        {
           
            

        }

        public void btnManageLec_Click(object sender, EventArgs e)
        {
            StreamReader myreader = new StreamReader("Student.txt", true);
            string line = "";
            string[] fields;

            while ((line = myreader.ReadLine()) != null)
            {
                fields = line.Split('#');
                if (linklblWelcome.Text == "Welcome" + "(" + fields[1] + "," + "\t" + fields[2] + ")")
                {

                    Form5 form5 = new Form5(fields[1],fields[2]);
                    form5.Show();
                    Visible = false;
                }
            }
            
        }

        public void btnManageMod_Click(object sender, EventArgs e)
        {
            StreamReader myreader = new StreamReader("Student.txt", true);
            string line = "";
            string[] fields;

            while ((line = myreader.ReadLine()) != null)
            {
                fields = line.Split('#');
                if (linklblWelcome.Text == "Welcome" + "(" + fields[1] + "," + "\t" + fields[2] + ")")
                {

                    Form6 form6 = new Form6(fields[1], fields[2]);
                    form6.Show();
                    Visible = false;
                }
            }

           
        }

        public void btnManageAss_Click(object sender, EventArgs e)
        {
            StreamReader myreader = new StreamReader("Student.txt", true);
            string line = "";
            string[] fields;

            while ((line = myreader.ReadLine()) != null)
            {
                fields = line.Split('#');
                if (linklblWelcome.Text == "Welcome" + "(" + fields[1] + "," + "\t" + fields[2] + ")")
                {

                    Form7 form7 = new Form7(fields[1], fields[2]);
                    form7.Show();
                    Visible = false;
                }
            }


           
        }

        public void btnSearchAss_Click(object sender, EventArgs e)
        {
            StreamReader myreader = new StreamReader("Student.txt", true);
            string line = "";
            string[] fields;

            while ((line = myreader.ReadLine()) != null)
            {
                fields = line.Split('#');
                if (linklblWelcome.Text == "Welcome" + "(" + fields[1] + "," + "\t" + fields[2] + ")")
                {

                    Form8 form8 = new Form8(fields[1], fields[2]);
                    form8.Show();
                    Visible = false;
                }
            }

        }

        public void linklblWelcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            StreamReader myreader = new StreamReader("Student.txt", true);
            string line = "";
            string[] fields;

            while ((line = myreader.ReadLine()) != null)
            {
                fields = line.Split('#');
                if (linklblWelcome.Text == "Welcome" + "(" + fields[1] + "," + "\t" + fields[2] + ")")
                {

                    Form4 form4 = new Form4(fields[0],fields[1],fields[2],fields[3]);
                    form4.Show();
                    Visible = false;
                }
            }
        }

        public void linklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }
    }
}

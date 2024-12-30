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
using System.Diagnostics;

namespace Semester_1_Assignment_1
{
    public partial class Form1 : Form
    {
        static int studentNumber = 215487878;
        public Form1()
        {
            InitializeComponent();
            
        }



        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {


            txtStudNo.Text = studentNumber.ToString();
           
            txtStudNo.Enabled = false;
        }
       
        public void txtStudNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void btnCreateAcc_Click(object sender, EventArgs e)
        {
           
            StreamWriter myWriter = new StreamWriter("Student.txt", true);
            {
                myWriter.WriteLine(txtStudNo.Text + "#" + txtStudName.Text + "#" + txtStudSurname.Text + "#" + txtStudEmail.Text + "#" + txtStudPassword.Text);
                myWriter.Close();
            }
            
            studentNumber = studentNumber + 1;
            txtStudNo.Text = studentNumber.ToString();

            txtStudNo.Enabled = false;
            


        }

        public void linklblHaveAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }

        public void txtStudPassword_TextChanged(object sender, EventArgs e)
        {
            txtStudPassword.PasswordChar = '*';
        }

        private void txtStudName_TextChanged(object sender, EventArgs e)
        {
           
            
           
        }
    }
}

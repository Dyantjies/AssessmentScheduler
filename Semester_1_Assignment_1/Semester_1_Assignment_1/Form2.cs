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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {



        }

        private void linklblDontHaveAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        public void btnSignIn_Click(object sender, EventArgs e)
        {

          
               StreamReader sreader = new StreamReader("Student.txt",true);
            {
                
                string line = "";
                string[] fields;
                

                while ((line = sreader.ReadLine()) != null)
                {
                    fields = line.Split('#');


                    if (txtEmail.Text == fields[3] && txtPassword.Text == fields[4])
                    {


                        Form3 form3 = new Form3(fields[1], fields[2]);
                        form3.Show();
                        Visible = false;
                    }
                    else if (txtEmail.Text != fields[3] || txtPassword.Text != fields[4])
                    {

                        lblCredInvalid.Text = "Invalid email and password.";
                    }
                }


                

                sreader.Close();



            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

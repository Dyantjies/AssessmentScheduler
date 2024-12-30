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
    public partial class Form4 : Form
    {
        

        public Form4(string s,string s1,string s2,string s3)
        {
            InitializeComponent();
            lblStudNo.Text = s;
            lblStudName.Text = s1;
            lblStudSurname.Text = s2;
            lblStudEmail.Text = s3;
            
        }

        public Form4()
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackToLanding_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(lblStudName.Text, lblStudSurname.Text);
            form3.Show();
            Visible = false;
        }
    }
}

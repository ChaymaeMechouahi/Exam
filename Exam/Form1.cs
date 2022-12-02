using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Exam
{
    public partial class Form1 : Form
    {
        string boxmat = "";
        string boxdat = "";
        string boxdure = "";
        string note = "";
        string question = "";
        string quenumb = "";
        string op1 = "";
        string op2 = "";
        string op3 = "";
        string op4 = "";
        bool checkVf = false;
        bool checkI = false;

        private static string dataconnection = @"DESKTOP-72A5J1H\SQLEXPRESS";
        private static string database = "Examen";
        private static string user = "root";
        private static string password = "";
        string connString = @"Data Source=" + dataconnection + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + user + ";Password=" + password;
        string querystring = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examenDataSet.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.examenDataSet.Exam);
            // TODO: This line of code loads data into the 'examenDataSet.Etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter.Fill(this.examenDataSet.Etudiant);
            box_date.Text = "";
            box_durée.Text = "";
            box_matiere.Text = "";
            box_note.Text = "";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            Refrech.Enabled = false;
            box_question.Enabled = false;
            textBox1.Enabled = false;
            box_opt1.Enabled = false;
            box_opt2.Enabled = false;
            box_opt3.Enabled = false;
            box_opt4.Enabled = false;
        }
        private void box_matiere_SelectedIndexChanged(object sender, EventArgs e)
        {
          boxmat = box_matiere.Text  ;
        }
        private void box_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxdat = box_date.Text;

        }
        private void box_durée_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxdure = box_durée.Text;

        }
        private void box_note_SelectedIndexChanged(object sender, EventArgs e)
        {
            note = box_note.Text;

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            querystring = "INSERT INTO Exam VALUES (boxmat,boxdat,boxdure,note) ";
            SqlCommand save = new SqlCommand(querystring, conn);
            try
            {
                MessageBox.Show("Openning Connection ...");

                //open connection
                conn.Open();

                MessageBox.Show("Connection successful!");
                save.ExecuteNonQuery();
             }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
            finally
            {
                //close connection 
                conn.Close();
            }
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            Refrech.Enabled = true;
            box_question.Enabled = true;
            textBox1.Enabled = true;
            box_opt1.Enabled = true;
            box_opt2.Enabled = true;
            box_opt3.Enabled = true;
            box_opt4.Enabled = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            box_opt1.Enabled = true;
            box_opt2.Enabled = true;
            box_opt3.Enabled = true;
            box_opt4.Enabled = true;


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            box_opt1.Enabled = false;
            box_opt2.Enabled = false;
            box_opt3.Enabled = false;
            box_opt4.Enabled = false;
            checkVf = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            box_opt1.Enabled = false;
            box_opt2.Enabled = false;
            box_opt3.Enabled = false;
            box_opt4.Enabled = false;
            checkI = true;
        }

        private void box_question_TextChanged(object sender, EventArgs e)
        {
            question = box_question.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            quenumb = textBox1.Text;
        }
        private void Refrech_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            querystring = "INSERT INTO QCM VALUES (box_opt1.Text,box_opt2.Text,box_opt3.Text) ";
            SqlCommand save = new SqlCommand(querystring, conn);
            try
            {
                MessageBox.Show("Openning Connection ...");

                //open connection
                conn.Open();

                MessageBox.Show("Connection successful!");
                save.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
            finally
            {
                //close connection 
                conn.Close();
            }
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            box_opt1.Enabled = false;
            box_opt2.Enabled = false;
            box_opt3.Enabled = false;
            box_opt4.Enabled = false;
        }

    }
}

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
            box_date.Text = "";
            box_durée.Text = "";
            box_matiere.Text = "";
            box_note.Text = "";

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

            
        }


    }
}

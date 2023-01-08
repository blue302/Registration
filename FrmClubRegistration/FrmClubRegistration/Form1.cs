using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClassRegistrationQuery clubRegistrationQuery = new ClassRegistrationQuery();
        private int Age;
        private int ID;
        private static int count =1 ;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationID(count++);// Keeps track of how many registration in each run of the program
            ID = int.Parse(tb_ID.Text.Substring(tb_ID.Text.Length - 4)); // I felt like the ID should have a unique value 
            StudentId = long.Parse(tb_ID.Text);                         //I then passed it as the value of the ID
            FirstName = tb_FirstName.Text;
            MiddleName = tb_MIddleName.Text;
            LastName = tb_LastName.Text;
            Age = int.Parse(tb_Age.Text);
            Gender = cb_Gender.Text;
            Program = cb_Program.Text;

            //The line bellow is the one responsible for passing the arguements into the RegisterStudent Method
            clubRegistrationQuery.RegisterStudent(ID,StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            RefreshListOfClubMembers();

            Console.WriteLine(count);
        }
        public void RefreshListOfClubMembers()
        {  
            if (clubRegistrationQuery != null)
            {
                clubRegistrationQuery.DisplayList();
            }
            if (dataGridView != null)
            {
                dataGridView.DataSource = clubRegistrationQuery?.bindingSource;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This event opens the FrmUpdateMember Form
            FrmUpdateMember frmupdatemember = new FrmUpdateMember();
            frmupdatemember.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //This event keeps the data grid view updated by refreshing and callinng upon the two methods bellow
            RefreshListOfClubMembers();
            DisplayData();
        }

        public int RegistrationID(int counter)
        {
            //this is for the counter
            return counter++;
        }
        
        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            // Makes sure that there is an updated data of the database to the grid view upon first running the program
            RefreshListOfClubMembers();
            DisplayData();
        }
        private void DisplayData()
        {
            // Everytime This is called it will show an update version of the ClubMembersTB 
            string connectionString = "Data Source=JJN\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";
            string selectCommand = "SELECT * FROM ClubMembers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection))
                {
                    DataTable LoadCM = new DataTable();
                    adapter.Fill(LoadCM);

                    dataGridView.DataSource = LoadCM;
                }
            }
        }
        public FrmClubRegistration()
        {
            InitializeComponent();
        }

    }
}

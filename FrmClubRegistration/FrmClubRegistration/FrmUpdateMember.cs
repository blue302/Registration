using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private ClassRegistrationQuery UpdateClub= new ClassRegistrationQuery();
        private FrmClubRegistration classes = new FrmClubRegistration();
        string connection = "Data Source=JJN\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";
        public FrmUpdateMember()
        {
            InitializeComponent();
        }
        
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            //The entire block of code within this method FrmUpdateMember_Load is the thing that allows the combobox to be updated
            //automatically the combobox will always contain all of the StudentID's Registered within the ClubMembers table
                string connectionString = "Data Source=JJN\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";
                string sql = "select StudentID from  ClubMembers ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (UpdateClub.GeneralAccess = command.ExecuteReader())//this is where i used the getter and setter
                        {                                                         //Whithin the general access sqlreader is stored as its value
                            DataTable dataTable = new DataTable();
                            dataTable.Load(UpdateClub.GeneralAccess); 

                            studentID.DataSource = dataTable;
                            studentID.DisplayMember = "StudentID";
                        }
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // In this even i instantiated all the un used variable added the input fields of the FrmUpdateMember form as its value 
            UpdateClub._StudentID = long.Parse(studentID.Text); 
            UpdateClub._FirstName = FirstNametb.Text;
            UpdateClub._MiddleName = MiddleNametb.Text;
            UpdateClub._LastName = LastNametb.Text;
            UpdateClub._Age = int.Parse(Agetb.Text);
            UpdateClub._Gender = GenderCB.Text;
            UpdateClub._Program= ProgramCB.Text;
            
            // I then used them all as arguements that will be passed on to the UpdateStudent Method
            UpdateClub.UpdateStudent(UpdateClub._StudentID, UpdateClub._FirstName, UpdateClub._MiddleName, UpdateClub._LastName, 
                                    UpdateClub._Age, UpdateClub._Gender, UpdateClub._Program);
            classes.RefreshListOfClubMembers(); // I then call the RefreshClass Method to update the Datagridview
            
        }


    }
}

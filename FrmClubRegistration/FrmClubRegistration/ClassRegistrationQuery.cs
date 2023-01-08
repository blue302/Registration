using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmClubRegistration
{
    
    internal class ClassRegistrationQuery
    {
        //static int count;
        public ClassRegistrationQuery()
        {
            connectionString = "Data Source=JJN\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            datatable = new DataTable();
            bindingSource = new BindingSource();
        }

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable datatable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;
        public long _StudentID;

        public SqlDataReader GeneralAccess //This getter and setter allows me to access the sqlReader
        {
            get { return sqlReader; }
            set { sqlReader = value; }
        }
        public void DisplayList()
        {
            //The ViewClubMember string variable contains the sql Query to display those within its parameters
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";

            sqlCommand = new SqlCommand(ViewClubMembers,sqlConnect);
            sqlAdapter = new SqlDataAdapter();

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            sqlCommandBuilder.DataAdapter = sqlAdapter;
            sqlAdapter.SelectCommand = sqlCommand;
            datatable.Clear();
            sqlAdapter.Fill(datatable);
            bindingSource.DataSource = datatable;
        }
        public bool RegisterStudent(int ID,long StudentID, string FirstName, string
        MiddleName, string LastName, int Age, string Gender, string Program)
        {
            //this was the code given in the activity
            sqlConnect.Open();
            sqlCommand = new SqlCommand("SET IDENTITY_INSERT ClubMembers ON;INSERT INTO ClubMembers(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program) Values(@ID, @StudentID,@FirstName, @MiddleName, @LastName, @Age, @Gender, @Program);SET IDENTITY_INSERT ClubMembers OFF;", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            //sqlCommand.Parameters.AddWithValue("@ID", count += 1);
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }
        //The Update Student method has a bool return type and is responsible for taking the values of the texboxes and inputing it to the Club Database
        public bool UpdateStudent(long StudentID, string FirstName, string
        MiddleName, string LastName, int Age, string Gender, string Program)
        {
            //this method is very similar to the Register student method I just thhe query so that instead of inserting new values it would update them
            sqlConnect.Open();
            sqlCommand = new SqlCommand("UPDATE ClubMembers Set FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program Where StudentID =@StudentID", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }
    }   
}

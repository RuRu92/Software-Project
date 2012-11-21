using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Project
{
    class DBconnector
    {
     private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public DBconnector()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        //connects to the localy hosted data base 
        server = "localhost";
        database = "timetablese";
        uid = "root";
        password = "root";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        // cerates a new connection to the database
        connection = new MySqlConnection(connectionString);
       

    }

    //Select statement for the lectuer
    public List<LecturerCL> SelectLectuer()
    {
        string query = "SELECT * FROM lecturer";

        // creats a  list  of lectuer objects
        List<LecturerCL> allLect = new List<LecturerCL>();
        
        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {   
                // adds the  data in the columes to the class varbiles and pass them in
                Int32 lectuerID = dataReader.GetInt32(0);
                String lectuerName = dataReader.GetString(1);
                Int32 requiedTeachingHrs = dataReader.GetInt32(2);
                Int32 teachingHrs = dataReader.GetInt32(3);
                // crates the  lectuer object  
                LecturerCL l = new LecturerCL(lectuerID, lectuerName,  teachingHrs, requiedTeachingHrs);
                // add all the curent  values to the  database
                allLect.Add(l);

            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();
        }
        // return all the records in the database for the lecturer
        return allLect;
    }

    //Insert statement for lectuer table
    public void InsertLect(LecturerCL l)
    {
        // query to allow data to  be placed  into the table  lectuere  on the  database from the lectuerCL class 
        string queryLect = "INSERT INTO lecturer (lecturerName, lecturerRequiredHours, lecturerTaughtHours) VALUES('" + l.lectName + "','" + l.ReqTeachingHrs + "','" + l.TeachingHrs + "')";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryLect, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
    public void DeleteLect(int id) 
    {

        // query to allow data to  be placed  into the table  lectuere  on the  database from the lectuerCL class 
        string queryLect = "DELETE FROM lecturer WHERE idLecturer = " + id + "";
        
        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryLect, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
   
    public List<YearGroupCL> SeclectYearGroup()
    {
        string query = "SELECT * FROM yeargroup";

        List<YearGroupCL> allYGrop = new List<YearGroupCL>();

         //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                Int32 YearGroupID = dataReader.GetInt32(0);
                String YearGroupName = dataReader.GetString(1);
                Int32 NumStudents = dataReader.GetInt32(2);

                YearGroupCL YG = new YearGroupCL(YearGroupID, YearGroupName, NumStudents);
                allYGrop.Add(YG);

            }
            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();
        }
        // return all the records in the database for the lecturer
        return allYGrop;
    }
    public void insertYG(YearGroupCL YG)
    {
        string queryYG = "INSERT INTO yeargroup (yearGroupName, noStudents) VALUE('" + YG.YearGropName + "','" 
        + YG.NumStudents  +"')";
        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryYG, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
    public void DeleteYG(int id)
    {

        // query to allow data to  be placed  into the table  lectuere  on the  database from the lectuerCL class 
        string queryYG = "DELETE FROM yeargroup WHERE idYearGroup = " + id + "";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryYG, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
    public List<ModuleCL> SeclectMod()
    {
        string query = "SELECT * FROM module";
        List<ModuleCL> allMod = new List<ModuleCL>();

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Int32 ModuleID = dataReader.GetInt32(0);
                String ModuleName = dataReader.GetString(1);
                Int32 ModuleHours= dataReader.GetInt32(2);
                Int32 ReqModHRS = dataReader.GetInt32(3);

                ModuleCL mod = new ModuleCL(ModuleID, ModuleName, ModuleHours, ReqModHRS);
                allMod.Add(mod);
                
            }
            //close Data Reader
            dataReader.Close();

            //close Connectionon
            this.CloseConnection();
        }
        return allMod;
    }

    public void insertMOD(ModuleCL Mod)
    {
        string qureyMod = "INSERT INTO module(moduleName, moduleRequiredHours ,moduleTaughtHours ) VALUE('" + Mod.ModuleName + "','"
        + Mod.ReqModHRS+"','"+ Mod.ModHrs+ "')";

        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(qureyMod, connection);
            //NOTE!! throws  exaption as to the  defluat data
            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
      

    } 
   public void DeleteMod(int id)
    {
        string queryMod = "DELETE FROM module  WHERE idModule = "+id+"";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryMod, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }

    }
    //open connection to database
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }
    

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }
  }
}

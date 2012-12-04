using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Project
{ 
    /// <summary>
    /// this class connects to the database 
    /// and holds all the methods for adding 
    /// and deleting 
    /// </summary>
    class DBconnector
    {
    // variables that allow a databases conection to be used
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

    /// <summary>
    /// Initialize the connection to
    /// the sever were the database is stored and the database 
    /// </summary>
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

    /// <summary>
    /// this seclests the lectuer from the database 
    /// to be used with in this code and  useing a  seclect  query 
    /// </summary>
    /// <returns>list of lectuerCl</returns>
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
                // add all the curent values to the database
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

   /// <summary>
    /// this method allows a user to insert an lectuer 
   /// infomation into the data base useing a Insert query 
   /// </summary>
   /// <param name="l"></param>
    public void InsertLect(LecturerCL l)
    {
        // query to allow data to be placed into the table lectuere on the database from the lectuerCL class 
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
    /// <summary>
    /// the delete method allows  user to delete a lectuer 
    /// </summary>
    /// <param name="id"></param>
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
   /// <summary>
   /// seclects the information from the database and return a list of YearGroupsCL
   /// </summary>
   /// <returns></returns>
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
    /// <summary>
    /// insert statement for the YearGroupCL 
    /// </summary>
    /// <param name="YG">List of  YearGroups</param>
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
    /// <summary>
    /// delete a year group based on the seclted   
    /// </summary>
    /// <param name="id"></param>
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

            //Execute command Throw Expctopn
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }

    }

    //Select statement for the lectuer
    public List<RoomCL> SelectRoom()
    {
        string query = "SELECT * FROM room";

        // creats a  list  of room objects
        List<RoomCL> allRoom = new List<RoomCL>();

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
                Int32 roomID = dataReader.GetInt32(0);
                String rName = dataReader.GetString(1);
                Int32 capacity = dataReader.GetInt32(2);
                String rType = dataReader.GetString(2);
                // add all the curent  values to the  database

                RoomCL r = new RoomCL(roomID, rName, rType, capacity);
                allRoom.Add(r);
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();
        }
        // return all the records in the database for the room
        return allRoom;
    }

    //Insert statement for room table
    public void InsertRoom(RoomCL r)
    {
        // query to allow data to  be placed  into the table  room  on the  database from the RoomCL class 
        string queryRoom = "INSERT INTO room (roomName, roomCapacity, roomType) VALUES('" + r.rName + "','" + r.capacity + "','" + r.rType + "')";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryRoom, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }

    public void DeleteRoom(int id)
    {
        string queryRoom = "DELETE FROM room  WHERE idRoom = " + id + "";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryRoom, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }

    public DataTable LessonVeiw()
    {
        string query = "SELECT module.moduleName, lecturer.lecturerName, yearGroup.yearGroupName, room.roomName, lesson.startTime, lesson.endTime, lesson.day" +
         " from lesson " +
        " left join module " +
        " on Lesson.module_idModule=module.idModule " +
        " left join lecturer " +
        " on Lesson.lecturer_idLecturer=lecturer.idLecturer " +
        " left join yearGroup " +
        " on Lesson.yearGroup_idYearGroup=yearGroup.idyearGroup " +
        " left join room " +
        " on Lesson.Room_idRoom=room.idRoom ";

            DataTable dt = new DataTable();
            dt.Columns.Add("Module", typeof(String));
            dt.Columns.Add("Lectuer", typeof(String));
            dt.Columns.Add("Year Group", typeof(String));
            dt.Columns.Add("Room", typeof(String));
            dt.Columns.Add("Start Time", typeof(String));
            dt.Columns.Add("End Time", typeof(String));
            dt.Columns.Add("Day", typeof(String));
            dt.AcceptChanges();
        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {

                object[] row = new object[]
                 {
                    dataReader.GetString(0),
                    dataReader.GetString(1),
                    dataReader.GetString(2),
                    dataReader.GetString(3),
                    dataReader.GetString(4),
                    dataReader.GetString(5),
                    dataReader.GetString(6)
                };
               
                dt.Rows.Add(row);
            }
            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();
            }
        // return all the records in the database for the lecturer
      return dt;
        }
    public List<LessonCL> SecletLesson()
    {
        string query = "SELECT * FROM lesson";

        // creats a  list  of lectuer objects
        List<LessonCL> allless = new List<LessonCL>();

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Int32 lessonID = dataReader.GetInt32(0);
                String lectName = dataReader.GetString(1);
                String ygName = dataReader.GetString(2);
                String roomsName = dataReader.GetString(3);
                String modName = dataReader.GetString(4);
                String lessTime = dataReader.GetString(5);
                String lessEndTime = dataReader.GetString(6);
                String lessDay = dataReader.GetString(7);

                LessonCL less = new LessonCL(lessonID, lectName, ygName, roomsName, modName, lessTime,lessEndTime, lessDay); 
                allless.Add(less);

            }
            //close Data Reader
            dataReader.Close();

            //close Connectionon
            this.CloseConnection();
        }
        return allless;
    }
    public int GetLessID(String lname, String ygroup, String roomN, String modn, String startTime, String day)
    {
        int lessid = -1;
         //Open connection
        if (this.OpenConnection() == true)
        {
            //Pulls id field from the lecturer table
            MySqlCommand cmd = new MySqlCommand("SELECT idLecturer from lecturer WHERE lecturerName='" + lname + "'", connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int lecturerid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();


            //Pulls id field from the table year group
            cmd = new MySqlCommand("SELECT idYearGroup from yeargroup WHERE yearGroupName='" + ygroup + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int ygid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();


            //Pulls id field from the room table
            cmd = new MySqlCommand("SELECT idRoom from room WHERE roomName='" + roomN + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int roomid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

            //Pulls id field from module the table
            cmd = new MySqlCommand("SELECT idModule from module WHERE moduleName='" + modn + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int modid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

            
            
            string qclash = "SELECT idLesson from lesson WHERE Lecturer_idLecturer=" + lecturerid + " And YearGroup_idYearGroup =" + ygid + " AND Room_idRoom=" + roomid + " AND Module_idModule=" + modid + " AND startTime='" + startTime + "' AND day='" + day + "';";
            cmd = new MySqlCommand(qclash, connection);
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            lessid = dataReader.GetInt32(0);
           
            //close Connectionon
            this.CloseConnection();
            
       
      }
        return lessid;
        
    }
    public void DeleteLess(int id)
    {
       
        string queryless = "DELETE FROM lesson WHERE module.moduleName, lecturer.lecturerName, yearGroup.yearGroupName, room.roomName, lesson.startTime, lesson.day" +
         "from lesson " +
        " left join module " +
        " on Lesson.module_idModule=module.idModule " +
        " left join lecturer " +
        " on Lesson.lecturer_idLecturer=lecturer.idLecturer " +
        " left join yearGroup " +
        " on Lesson.yearGroup_idYearGroup=yearGroup.idyearGroup " +
        " left join room " +
        " on Lesson.Room_idRoom=room.idRoom ";

        //open connection
        if (this.OpenConnection() == true)
        {
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(queryless, connection);

            //Execute command
           cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }
    public void InsertLess(LessonCL less)
    {
        //INSERT INTO lesson(idLesson, Lecturer_idLecturer, YearGroup_idYearGroup, Room_idRoom, Module_idModule )  VALUES('0','Nigel Edwards','BSc Computer Science Yr 2','Y106','Database Design')
        //Pulls id field from the lecturer table

        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT idLecturer from lecturer WHERE lecturerName='" + less.lectName + "'", connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int lecturerid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

            //Pulls id field from the table year group
            cmd = new MySqlCommand("SELECT idYearGroup from yeargroup WHERE yearGroupName='" + less.ygName + "'" , connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int ygid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();


            //Pulls id field from the room table
            cmd = new MySqlCommand("SELECT idRoom from room WHERE roomName='" + less.roomsName + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int roomid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

            //Pulls id field from module the table
            cmd = new MySqlCommand("SELECT idModule from module WHERE moduleName='" + less.modName + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int modid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();


             //cmd =new MySqlCommand("SELECT idLesson from lesson WHERE startTime='" + startTime + "'", connection);
             //cmd = new MySqlCommand("SELECT idlesson from lesson WHERE endtime='" + endTime + "'", connection);
             //   cmd = new MySqlCommand("SELECT idLesson from lesson WHERE day ='" + day + "'", connection);

            //create command and assign the query and connection from the constructor
            string qureyLesson = "INSERT INTO lesson(idLesson, Lecturer_idLecturer, YearGroup_idYearGroup, Room_idRoom, Module_idModule, startTime, endTime, day ) VALUES('" + less.lessID + "','" + lecturerid + "','" + ygid + "','" + roomid + "','" + modid + "','" + less.startTime +"','"+ less.endTime +"','" +less.Day+ "')";
            cmd = new MySqlCommand(qureyLesson, connection);
            
            //NOTE!! throws  exaption as to the  defluat data
            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
        }
    }

    public Boolean checkClash(String lname, String ygroup, String roomN, String modn, String startTime,String endTime, String day)
    {
        Boolean res = true;
        
        //Open connection
        if (this.OpenConnection() == true)
        {
            
            //Pulls id field from the lecturer table
            MySqlCommand cmd = new MySqlCommand("SELECT idLecturer from lecturer WHERE lecturerName='" + lname + "'", connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int lecturerid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();


            //Pulls id field from the table year group
            cmd = new MySqlCommand("SELECT idYearGroup from yeargroup WHERE yearGroupName='" + ygroup + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int ygid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

           
            //Pulls id field from the room table
            cmd = new MySqlCommand("SELECT idRoom from room WHERE roomName='" + roomN + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int roomid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

            //Pulls id field from module the table
            cmd = new MySqlCommand("SELECT idModule from module WHERE moduleName='" + modn + "'", connection);
            //Create a data reader and Execute the command
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            int modid = dataReader.GetInt32(0);
            //close Data Reader
            dataReader.Close();

            cmd = new MySqlCommand("SELECT idLesson from lesson WHERE startTime='" + startTime + "'", connection);
            cmd = new MySqlCommand("SELECT idlesson from lesson WHERE endtime='" + endTime + "'", connection);
             cmd = new MySqlCommand("SELECT idLesson from lesson WHERE day ='"+ day+ "'", connection);

            // Uses the query to check if there is a clash in lesson table
            //SELECT count(*) from lesson WHERE Lecturer_idLecturer=1 And YearGroup_idYearGroup =1 AND Room_idRoom=1 AND Module_idModule=1 AND startTime='08:00'AND day='Monday';
            string qclash = "SELECT count(*) from lesson WHERE Lecturer_idLecturer=" + lecturerid + " And YearGroup_idYearGroup =" + ygid + " AND Room_idRoom=" + roomid + " AND Module_idModule=" + modid + " AND startTime='" + startTime + "' AND endTime='"+ endTime +"' AND day='" + day + "';";
            cmd = new MySqlCommand(qclash, connection);
            dataReader = cmd.ExecuteReader();
            dataReader.Read();
            res = dataReader.GetInt32(0) > 0 ? true : false;
            //close Data Reader
            dataReader.Close();

            //close Connectionon
            this.CloseConnection();
        }
        return res;
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

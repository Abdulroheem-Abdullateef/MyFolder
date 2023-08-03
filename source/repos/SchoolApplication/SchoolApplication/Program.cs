using System;
using MySql.Data.MySqlClient;
namespace SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //// without close using
            //var connectionstring = "server=localhost;user=root;database=Schoolapp2;password=07067008860";

            //MySqlConnection sqlConnection = new MySqlConnection(connectionstring);
            //sqlConnection.Open();

            //// to insert to Mysql

            //MySqlCommand mySqlCommand1 = new MySqlCommand("insert into student(FirstName,Lastname,Email,regNumber,Gender)values ('Salaudeen','Haleem','salaudeen@gmail.com','90483sdrf','Male')", sqlConnection);
            //var sqlcommand2 = mySqlCommand1.ExecuteNonQuery();

            //MySqlCommand mySqlCommand2 = new MySqlCommand("insert into student(FirstName,Lastname,Email,regNumber,Gender,Phone)values ('Salaudeen','Haleem','salaudeen@gmail.com','90483sdrf','Male','0707089908770')", sqlConnection);
            //var sqlcommand3 = mySqlCommand2.ExecuteNonQuery();

            ////to read to Mysql

            
            //Console.WriteLine("connection successfully");

            //MySqlCommand mySqlCommand = new MySqlCommand("select * from student",sqlConnection);
            //var reader = mySqlCommand.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine("{0},{1},{2}", reader["FirstName"], reader["LastName"],reader["Email"]);
            //}

            //sqlConnection.Close();




            

            try
            {
                var connect = "server=localhost;user=root;database=Schoolapp2;password=07067008860";

                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    MySqlCommand mySqlCommand2 = new MySqlCommand("insert into student (FirstName,Lastname,Email,regNumber,Gender,Phone)values ('Salaudeen','Haleem','salaudeen123@gmail.com','90483sdrf','Male','0707089908770')", connection);
                    var result = mySqlCommand2.ExecuteNonQuery();
                    MySqlCommand mySqlCommand1 = new MySqlCommand("select * from student", connection);
                    var sqlcommand2 = mySqlCommand1.ExecuteReader();
                    Console.WriteLine($"Number of rows affected: {result}");

                    while (sqlcommand2.Read())
                    {
                        Console.WriteLine("{0},{1},{2}", sqlcommand2["FirstName"], sqlcommand2["LastName"], sqlcommand2["Email"]);
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }







































        }
    }
}

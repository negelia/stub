using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using MySql.Data.MySqlClient;

using System.Data;
using System.Data.SqlClient;
using ClassLibrary1.DataSet1TableAdapters;
using System.Globalization;

namespace ClassLibrary1
{
    class FileDataObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();

            //обратиться к бд
            string path = @"Data Source=LAPTOP-3CDDHCO8\SQLEXPRESS;Initial Catalog=basedate;Integrated Security=True";
            string sqlExpression = "SELECT * FROM Employees";

            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    //Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read()) // построчно считываем данные
                    {
                        object ID_Employees = reader.GetValue(0);
                        object Name = reader.GetValue(1);
                        object Surname = reader.GetValue(2);
                        object Middle_Name = reader.GetValue(3);

                        //Console.WriteLine("{0} \t{1} \t{2}", id, name, age);

                        list.Add(Surname.ToString());
                        
                        DirectoryInfo d = new DirectoryInfo(path);
                        FileInfo[] files = d.GetFiles();

                        foreach (var file in files) { list.Add(file.Name); }
                    }
                }
                reader.Close();
            }
            return list;
        }
    }
}

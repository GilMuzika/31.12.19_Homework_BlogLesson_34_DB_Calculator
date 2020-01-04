using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._12._19_Homework_BlogLesson_34_DB_Calculator
{
    class DAO
    {
        private SQLiteConnection _connection = new SQLiteConnection();
        private SQLiteCommand _command = new SQLiteCommand();

        public DAO()
        {
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["companyDb_local"].ConnectionString.Replace(@"=\", $"={Directory.GetCurrentDirectory()}\\");
            _command.CommandType = System.Data.CommandType.Text;
            _command.Connection = _connection;

            FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
            FlexibleMessageBox.MAX_HEIGHT_FACTOR = Screen.PrimaryScreen.WorkingArea.Height;
        }

        public void addNumber(decimal number, string table_columnName)
        {
            try
            {
                _connection.Open();
                _command.CommandText = $"INSERT INTO {table_columnName} ({table_columnName}) VALUES ({number})";
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }
        public string Calculate(string operation)
        {
            string rez = string.Empty;
            _connection.Open();
            if (operation.Equals("/"))
            {
                rez += CalculateInternal("/") + ".";
                rez += CalculateInternal("%");
            }
            else
            {

                rez = CalculateInternal(operation).ToString();
            }
            _command.CommandText = $"INSERT INTO result (rowResult) VALUES ('{rez}')";
            _command.ExecuteNonQuery();


            _connection.Close();
            return rez;
        }
        private int CalculateInternal(string operation)
        {
            //_connection.Open();
            object rezult = null;
            _command.CommandText = $"SELECT (X {operation} Y) as rez FROM X CROSS JOIN Operation CROSS JOIN Y";
            using (SQLiteDataReader reader = _command.ExecuteReader())
            {
                while(reader.Read())
                {
                    rezult = reader.GetValue(0);
                }
            }
                //_connection.Close();
            if(rezult == null) throw new Exception("Something went wrong");
            return Convert.ToInt32(rezult);
        }






    }
}

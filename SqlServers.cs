using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace Alter_Flat_Parameter
{
    public class SqlServers
    {

        public SqlConnection common_SQL;
      
        public SqlConnection str_Sql_connection(string _DataBase, string _ServerName, string _User_ID,string _Password)
        {
            string str_SQL_connect="Password="+_Password+
                                  ";Persist Security Info=false"+
                                  ";User ID="+ _User_ID+
                                  ";Initial Catalog="+ _DataBase+
                                  ";Data Source="+ _ServerName;//Server IP Address
            SqlConnection SQLconnect = new SqlConnection(str_SQL_connect);
            return SQLconnect;
        }



        public string Sql_insert { get;private set; }
        //public void str_Sql_insert(string _Table_name,string _Column_Name)
        //{
        //    Sql_insert ="INSERT INTO "+_Table_name+"("+_Column_Name+")"+"VALUES(@value)";
        //}

        public void str_Sql_insert(string _Table_name, string _EN_NO, string _date, string _clicks, string _dxfs,string _Domain, string _LoginName, string _MachineName,string _IPAddress)
        {
            Sql_insert = "INSERT INTO " + _Table_name + "(" + _EN_NO + "," + _date + "," + _clicks + "," + _dxfs +","+ _Domain+","+ _LoginName + ","+ _MachineName + ","+ _IPAddress+")" +
                "VALUES(@Enclosure_NO,@Date,@Click_times,@DXF_count,@DomainName,@LoginName,@MachineName,@IPAddress)";
        }

        public void Date_Insert<T1,T2,T3,T4,T5,T6,T7,T8>(SqlConnection _SQLconnect,T1 _value1,T2 _value2,T3 _value3,T4 _value4,T5 _value5, T6 _value6,T7 _value7,T8 _value8)
        {
            
            //_SQLconnect.Open();
               
            using(SqlCommand cmd_insert=new SqlCommand(Sql_insert, _SQLconnect))
            {
                cmd_insert.Parameters.AddWithValue("@Enclosure_NO", _value1);
                cmd_insert.Parameters.AddWithValue("@Date", _value2);
                cmd_insert.Parameters.AddWithValue("@Click_times", _value3);
                cmd_insert.Parameters.AddWithValue("@DXF_count", _value4);
                cmd_insert.Parameters.AddWithValue("@DomainName", _value5);
                cmd_insert.Parameters.AddWithValue("@LoginName", _value6); 
                cmd_insert.Parameters.AddWithValue("@MachineName", _value7);
                cmd_insert.Parameters.AddWithValue("@IPAddress", _value8);
                cmd_insert.ExecuteNonQuery();
            }

            
        }





    }


}

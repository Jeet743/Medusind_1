using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO
{
    class Code_Employee
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public double empsal { get; set; }
        public char emptype { get; set; }

        DataAccess da = new DataAccess();

        public void Display()
        {
            da.Display();
        }

        
    }

    class DataAccess
    {
        SqlConnection con = null;
        SqlCommand cmd;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-7MGDTGQ\\SQLEXPRESS;Initial Catalog=MedusindDB;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }

        public void Display()
        {
            try
            {
                con = GetConnection();
                SqlDataReader dr;
                string s1 = "Select * from Code_Employee";
                cmd = new SqlCommand(s1, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write(dr["empno"] + "  " + dr["empname"] + "  " + dr["empsal"] + " " + dr["emptype"]);
                    Console.WriteLine();
                }
                
            }
            catch(SqlException se) 
            {
                Console.WriteLine(se.Message);
            }
        }

        public void Procedure()
        {
            con = GetConnection();

            Console.WriteLine("Please Enter Employee Number: ");
            int eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Employee Salary: ");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Employee Type (P-Parttime / F-Fulltime): ");
            char etype = Convert.ToChar(Console.ReadLine());

            cmd = new SqlCommand("MyProc",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.Parameters.AddWithValue("@ename", name);
            cmd.Parameters.AddWithValue("@esal", sal);
            cmd.Parameters.AddWithValue("@etype", etype);

           
            con.Close();

           
        }
    }

    class Connected
    {
        static void Main(string[] args)
        {
            Code_Employee ce = new Code_Employee();
            
            DataAccess d = new DataAccess();

            d.Procedure();
            //ce.Display();
            Console.Read();
        }
    }
}

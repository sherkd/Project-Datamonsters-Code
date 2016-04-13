using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Npgsql;

namespace Parcer_
{
    internal class Parcer_Fietsdiefstal
    {
        public void fietsdiefstal()
        {
            int j = 0;
            List<string[]> members = new List<string[]>();
            try
            {

                using (StreamReader parser = new StreamReader("D:/Github_zooi/Project3_ DataMonsters/Code/Versie 0.1/FietsdiefstalData.csv"))

                {
                    string line;
                    NpgsqlConnection conn = new NpgsqlConnection("Host=127.0.0.1;Username=postgres;Password=sqltestingdata;Database=TestingParcer");
                    //SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");
                    //SqlConnection myConnection = new SqlConnection("user id=postgres;" +
                    //                   "password=sqltestingdata;server=(localhost);" +
                    //                   "Trusted_Connection=yes;" +
                    //                   "database=TestingParcer; " +
                    //                   "connection timeout=30");
                    conn.Open();
                    while (!parser.EndOfStream)

                    {
                        line = parser.ReadLine();
                        string[] split_Value = line.Split(',');                        
                        string Voorval_nr = Convert.ToString(split_Value[0]);                        
                        if (Voorval_nr[0] == '"')
                        {
                            Voorval_nr = Voorval_nr.Remove(0, 1);
                        }
                        string begintijd = Convert.ToString(split_Value[13]);
                        string eindtijd = Convert.ToString(split_Value[16]);
                        string gemiddelde_jaar = Convert.ToString(split_Value[17]);
                        string gemiddelde_maand = Convert.ToString(split_Value[18]);
                        string gemiddelde_dag = Convert.ToString(split_Value[19]);
                        string merk = Convert.ToString(split_Value[22]);
                        string type = Convert.ToString(split_Value[23]);
                        string plaats = Convert.ToString(split_Value[7]);
                        string buurt = Convert.ToString(split_Value[8]);




                        //string insertString = "INSERT INTO Straatroven(voorval_nr)values (@Voorval_nr)";

                        NpgsqlCommand cmd = new NpgsqlCommand();
                        Console.WriteLine(buurt);
                        if (plaats == "ROTTERDAM")
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO Fietsdiefstal (Voorval_nr,begintijd,eindtijd, gemiddelde_jaar, gemiddelde_maand, gemiddelde_dag, merk, type, plaats, buurt) VALUES ('" + Voorval_nr + "','" + begintijd + "','" + eindtijd + "','" + gemiddelde_jaar + "','" + gemiddelde_maand + "','" + gemiddelde_dag + "','" + merk + "','" + type + "','" + plaats + "','" + buurt + "')";

                            //SqlCommand cmd = new SqlCommand(insertString, conn);
                            
                            //cmd.Parameters.AddWithValue("@Voorval_nr", Voorval_nr);
                            cmd.ExecuteNonQuery();
                            //cmd.ExecuteScalar();
                        }

                        //Console.WriteLine(split_Value[14]);
                        //Console.ReadLine();
                        //// commentaar hebben we hier liever niet                   
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
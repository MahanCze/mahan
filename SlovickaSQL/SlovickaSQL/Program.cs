using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovickaSQL
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *  _____ _______         _                      _              
             * |_   _|__   __|       | |                    | |             
             *   | |    | |_ __   ___| |___      _____  _ __| | __  ___ ____
             *   | |    | | '_ \ / _ \ __\ \ /\ / / _ \| '__| |/ / / __|_  /
             *  _| |_   | | | | |  __/ |_ \ V  V / (_) | |  |   < | (__ / / 
             * |_____|  |_|_| |_|\___|\__| \_/\_/ \___/|_|  |_|\_(_)___/___|
             * 
             * IT ZPRAVODAJSTVÍ  <>  PROGRAMOVÁNÍ  <>  HW A SW  <>  KOMUNITA
             * 
             * Tento zdrojový kód je součástí výukových seriálů na 
             * IT sociální síti WWW.ITNETWORK.CZ	
             *	
             * Kód spadá pod licenci prémiového obsahu a vznikl díky podpoře
             * našich členů. Je určen pouze pro osobní užití a nesmí být šířen.
             *
             */
		
            string connectionString = @"Data Source=localhost\MSSQLSERVER2008;Initial Catalog=SlovnicekDB;Integrated Security=True";
            using (SqlConnection spojeni = new SqlConnection(connectionString))
            {             
                spojeni.Open();

                Console.WriteLine("Zadej anglické slovíčko k překladu");
                string slovo = Console.ReadLine();
                string dotaz = "SELECT Czech FROM Word WHERE English=@slovo";
                using (SqlDataAdapter adapter = new SqlDataAdapter(dotaz, spojeni))
                using (DataSet vysledky = new DataSet())
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@slovo", slovo);
                    adapter.Fill(vysledky);

                    Console.WriteLine("Překlad: {0}", vysledky.Tables[0].Rows[0]["Czech"]);
                }
                spojeni.Close();
            }
            Console.ReadKey();
        }
    }
}

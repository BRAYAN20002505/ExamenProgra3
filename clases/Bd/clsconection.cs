using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace proyecto1progra3Brayan.clases.Bd
{
    class clsconection
    {
        private static string cadenaConexion= "Database=base_juego_a; Data Source= localhost; User Id= root; Password=";
        public static MySqlConnection conectar()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(cadenaConexion);
                return cn;
            }
            catch(MySqlException e)
            {
                Console.WriteLine("Error:" + e.Message);
                return null;
            }
        }


        public DataTable consultaTablaDirecta(String sqll)
        {
            MySqlConnection cn = conectar();
            cn.Open();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand(sqll, cn);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cn.Close();
            return dataTable;
        }



        public void queryInsertar(string c1, string c2, int validar)
        {
            

                clslistas nuevolist = new clslistas();
                nuevolist.cargarlistas();
                for(int i=0; i<nuevolist.nombre.Count; i++) 
                {
                    if(c1 == nuevolist.nombre[i]){

                        validar = 1;

                    }
                }

            if (validar == 0)
            {

                string cuerito = "insert into basearbol (NAnimales,DescripcionA) values ('" + c1 + "','" + c2 + "')";
                MySqlConnection cn = conectar();
                cn.Open();

                try
                {
                    MySqlCommand cm = new MySqlCommand(cuerito, cn);
                    cm.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error Al Guardar El Registro" + ex.Message);

                }
                finally
                {
                    cn.Close();
                }
        }   }


      





    }
}

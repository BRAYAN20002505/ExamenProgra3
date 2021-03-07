using proyecto1progra3Brayan.clases.Bd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace proyecto1progra3Brayan
{
    class clslistas
    {

        //se crean las litas
        //este metodo se conecta con la db para almacenar datos en las listas
        public List<string> nombre = new List<string>();
        public List<string> descripcion = new List<string>();
        
        
        public void cargarlistas()
        {
            string cuerito = "SELECT *  FROM basearbol";
            clsconection conexion = new clsconection();
            DataTable table= conexion.consultaTablaDirecta(cuerito);
            foreach (DataRow dr in table.Rows)
            {

           //aca se llaman las columnas de la db para cargarlos en la lista
                nombre.Add(dr["NAnimales"].ToString());
                descripcion.Add(dr["DescripcionA"].ToString());
                
                
         
            }
            
      

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clRol
    {
        public int idRol { get; set; }
        public string nombreRol { get; set; }
        public string nombreFormulario { get; set; }
        public int idPermiso { get; set; }
        public string nombrePermiso { get; set; }
        public int permiso { get; set; }

        /// <summary>
        /// Metodo Registrar Rol con solo nombre.
        /// </summary>
        clConexion objConexion = new clConexion();
        public int mtdRegistrarRol() //Registra en la tabla Rol
        {
            string consulta = "insert into rol(nombre) values ('" + nombreRol + "')";
            
            int rows=0;
            rows=objConexion.mtdConectado(consulta);
            
            return rows;

        }
        /// <summary>
        /// consultar datos en la tabla rol
        /// </summary>
        /// <returns>lista datos</returns>
        public List<clRol> mtdConsultarRol() // consultar datos en la tabla rol
        {
            string consulta = "select * from rol";
            DataTable infoRol = new DataTable();
          infoRol=  objConexion.mtdDesconectado(consulta);
            List<clRol> listaRol = new List<clRol>();
            for (int i = 0; i < infoRol.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idRol = int.Parse(infoRol.Rows[i][0].ToString());
                objRol.nombreRol = infoRol.Rows[i][1].ToString();
                listaRol.Add(objRol);

            }
            return listaRol;

        }
        public List<clRol> mtdPermisos() 
        {
           string consulta = "select * from permiso";
            DataTable datos = new DataTable();
           datos= objConexion.mtdDesconectado(consulta);
            List<clRol> listaPermisos = new List<clRol>();
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                clRol objRol = new clRol();
                objRol.idPermiso = int.Parse(datos.Rows[i][0].ToString());
                objRol.nombrePermiso = datos.Rows[i][1].ToString();
                objRol.permiso = int.Parse(datos.Rows[i][2].ToString());


                listaPermisos.Add(objRol);
            }
            return listaPermisos;


        }
    }
}
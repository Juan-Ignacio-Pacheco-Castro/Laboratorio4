using Laboratorio4.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio4.Handlers
{
    public class PlanetasHandler
    {
        private SqlConnection conexion;
        private string rutaConexion;

        public PlanetasHandler()
        {
            rutaConexion = ConfigurationManager.ConnectionStrings["PlanetasConnection"].ToString();
            conexion = new SqlConnection(rutaConexion);
        }
    }
}
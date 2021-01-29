using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hemeroteca.Entidades;
using System.Data.SQLite;

namespace Hemeroteca.Controladores
{
    class pRevistaFacultad
    {
        public static List<RevistaFacultad> GetAll()
        {
            List<RevistaFacultad> revfac = new List<RevistaFacultad>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, idRevista, idFacultad FROM RevistaFacultad;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                revfac.Add(new RevistaFacultad(obdr.GetInt32(0), pRevista.GetById(1), pFacultad.GetbyId(2)));
            }
            return revfac;

        }


        }
}

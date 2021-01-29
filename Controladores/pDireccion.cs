﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Hemeroteca.Entidades;

namespace Hemeroteca.Controladores
{
    class pDireccion
    {
        public static void Insert(Direccion d)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO DIRECCION(calle, numero, dpto, codigoPostal, idCiudad) VALUES (@calle, @numero, @dpto, @codigoPostal, @idCiudad)");
            cmd.Parameters.Add(new SQLiteParameter("@calle", d.Calle));
            cmd.Parameters.Add(new SQLiteParameter("@numero", d.Numero));
            cmd.Parameters.Add(new SQLiteParameter("@dpto", d.Dpto));
            cmd.Parameters.Add(new SQLiteParameter("@codigoPostal", d.Codigopostal));
            cmd.Parameters.Add(new SQLiteParameter("@idCiudad", d.Ciudad.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Updated(Direccion d)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE DIRECCION SET calle = @calle, numero=@numero, dpto = @dpto, codigoPostal = @codigoPostal, idCiudad = @idCiudad WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@calle", d.Calle));
            cmd.Parameters.Add(new SQLiteParameter("@numero", d.Numero));
            cmd.Parameters.Add(new SQLiteParameter("@dpto", d.Dpto));
            cmd.Parameters.Add(new SQLiteParameter("@codigoPostal", d.Codigopostal));
            cmd.Parameters.Add(new SQLiteParameter("@idCiudad", d.Ciudad.Id));
            cmd.Parameters.Add(new SQLiteParameter("@id", d.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static void Delete(Direccion d)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM DIRECCION where id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", d.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static Direccion GetById(int id)
        {
            Direccion d = new Direccion();
            Conexion.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, calle, numero, dpto, codigoPostal, idCiudad FROM DIRECCION WHERE id = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                d.Id = obdr.GetInt32(0);
                d.Calle = obdr.GetString(1);
                d.Numero = obdr.GetInt32(2);
                d.Dpto = obdr.GetString(3);
                d.Codigopostal = obdr.GetInt32(4);
                d.Ciudad = pCiudad.GetById(obdr.GetInt32(5));
            }
            return d;

        }

        public static List<Direccion> Buscar(string text)
        {
            List<Direccion> direcciones = new List<Direccion>();
            //creo el comando sql a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM DIRECCION WHERE calle LIKE @texto;");
            cmd.Parameters.Add(new SQLiteParameter("@texto", text));
            //asigno la conexion al comando
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader obdr = cmd.ExecuteReader();
            //recorro el datareader

            while (obdr.Read())
            {
                Direccion d = new Direccion();
                d.Id = obdr.GetInt32(0);
                d.Calle = obdr.GetString(1);
                d.Numero = obdr.GetInt32(2);
                d.Dpto = obdr.GetString(3);
                d.Codigopostal = obdr.GetInt32(4);
                d.Ciudad = pCiudad.GetById(5);
                direcciones.Add(d);

            }
            return direcciones;


        }


        public static List<Direccion> GetAll()  //SELECT 
        {
            List<Direccion> direcciones = new List<Direccion>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, calle, numero, dpto, codigoPostal, idCiudad FROM DIRECCION;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Direccion d = new Direccion();
                d.Id = obdr.GetInt32(0);
                d.Calle = obdr.GetString(1);
                d.Numero = obdr.GetInt32(2);
                d.Dpto = obdr.GetString(3);
                d.Codigopostal = obdr.GetInt32(4);
                d.Ciudad = pCiudad.GetById(5);
                direcciones.Add(d);
            }
            return direcciones;
        }


    }
}

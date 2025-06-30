﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TDS01___GPSFrancisco.Classe
{
    public class Conexao
    {
        private static string conString = "Server=localhost;Port=3306;DataBase=dbfrancisco;Uid=root;Pwd=''";
        private static MySqlConnection con = null;

        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(conString);
            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                return con = null;
            }
            return con;
        }

        public static void fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}

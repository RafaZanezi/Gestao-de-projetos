﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace Conexao
{
    class Conexao
    {
        private string connString = @"Host=127.0.0.1;Username=postgres;Password=Senh@123;Database=Gestao_projDB";

        static void Main()
        {
            {
                using (NpgsqlConnection Conexao = new NpgsqlConnection(connString))
                {
                    Conexao.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {


                    }

                    Conexao.Close();
                }
            }
        }

    }
}

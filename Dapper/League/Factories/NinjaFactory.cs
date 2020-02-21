using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Options;
using League.Models;

namespace League.Factories
{
    public class NinjaFactory
    {
        private MySqlOptions _options;
        public NinjaFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(_options.ConnectionString);
            }
        }

        public void Add(Ninja ninja)
        {
            using (IDbConnection dBConnection = Connection)
            {
                string query = "INSERT INTO ninjas (name, level, description, dojo_id, created_at, updated_at) VALUES (@name, @level, @description, @dojo_id, NOW(), NOW())";
                dBConnection.Open();
                dBConnection.Execute(query, ninja);
            }
        }

        public IEnumerable<Ninja> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Ninja>("SELECT * FROM ninjas");
            }
        }

        public Ninja FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                Ninja myNinja = dbConnection.Query<Ninja>("SELECT ninjas.name, ninjas.level, ninjas.description, dojos.name as dojo_name FROM ninjas JOIN dojos ON ninjas.dojo_id = dojos.id WHERE ninjas.id = @id ", new { id = id }).FirstOrDefault();
                return myNinja;
            }
        }

        public IEnumerable<Ninja> NinjasWithDojos()
        {
            using (IDbConnection dbConnection = Connection)
            {
                var query = $"SELECT * FROM ninjas JOIN dojos ON ninjas.dojo_id = dojos.id";
                dbConnection.Open();

                IEnumerable<Ninja> myNinjas = dbConnection.Query<Ninja, Dojo, Ninja>(query, (Ninja, dojo) => { Ninja.dojo = dojo; return Ninja; });
                return myNinjas;
            }
        }
    }
}

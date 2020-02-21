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
    public class DojoFactory
    {

        private MySqlOptions _options;
        public DojoFactory(IOptions<MySqlOptions> config)
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

        public void Add(Dojo dojo)
        {
            using (IDbConnection dBConnection = Connection)
            {
                string query = "INSERT INTO dojos (name, location, description, created_at, updated_at) VALUES (@name, @location, @description, NOW(), NOW())";
                dBConnection.Open();
                dBConnection.Execute(query, dojo);
            }
        }

        public IEnumerable<Dojo> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Dojo>("SELECT * FROM dojos");
            }
        }

        public Dojo FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var query =
                @"
                SELECT * FROM dojos WHERE id = @id;
                SELECT * FROM ninjas WHERE dojo_id = @id;
                ";

                using (var multi = dbConnection.QueryMultiple(query, new { id = id }))
                {
                    Dojo dojo = multi.Read<Dojo>().Single();
                    dojo.ninjas = multi.Read<Ninja>().ToList();
                    return dojo;
                }
            }
        }
    }
}

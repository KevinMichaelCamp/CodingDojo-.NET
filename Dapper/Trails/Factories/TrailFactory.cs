using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using Trails.Models;
using Microsoft.Extensions.Options;

namespace Trails.Factories
{
    public class TrailFactory
    {
        private MySqlOptions _options;
        public TrailFactory(IOptions<MySqlOptions> config)
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

        public void Add(Trail trail)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO trails (name, description, length, elevation_change, latitude, longitude, created_at, updated_at) VALUES (@Name, @Description, @Length, @Elevation_Change, @Latitude, @Longitude, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, trail);
            }
        }

        public IEnumerable<Trail> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails");
            }
        }

        public Trail FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
    }
}
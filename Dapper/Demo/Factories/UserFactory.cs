using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using Demo.Models;
using Microsoft.Extensions.Options;

namespace Demo.Factories
{
    public class UserFactory
    {
        private MySqlOptions _options;
        public UserFactory(IOptions<MySqlOptions> config)
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

        public void Add(User user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO users (name, email, password, created_at, updated_at) VALUES (@Name, @Email, @Password, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, user);
            }
        }

        public IEnumerable<User> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<User>("SELECT * FROM users");
            }
        }

        public User FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<User>("SELECT * FROM users WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

    }

}
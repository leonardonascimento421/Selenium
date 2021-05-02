using LiteDB;
using Luminus.Selenium.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public class KeyValueRepository : IRepository<KeyValueEntity>
    {
        private readonly string _connectionString;

        public KeyValueRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public KeyValueEntity Get(string id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var dbSet = db.GetCollection<KeyValueEntity>("KeyValueEntity");

                return dbSet.FindOne(x => x.Id == id);
            }
        }

        public void Save(KeyValueEntity entity)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var dbSet = db.GetCollection<KeyValueEntity>("KeyValueEntity");

                dbSet.Upsert(entity);
            }
        }
    }
}

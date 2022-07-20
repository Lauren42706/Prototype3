using System.Collections.Generic;
using System.Threading.Tasks;
using Prototype2.Model;
using SQLite;

namespace Prototype2.Services
{
    public class Database
    {
        /// <summary>
        /// Real databases would use Dependancy Injections and Interfaces.
        /// Use EntityFrameworkCore
        /// </summary>


        //The connection to the Database.
        private readonly SQLiteAsyncConnection _database;


        //Constructor where the tables are created for storage.
        public Database(string dbPath) 
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserData>();
        }


        //Gets a list of user data.
        public Task<List<UserData>> GetUserDataAsync() 
        {
            return _database.Table<UserData>().ToListAsync();
            //This line of code means that all the records or data in the table are accesible from here.
            //This is also the part of the code where we would be able to right query code.
        }


        //Takes an object and stores it in the table.
        public Task<int> SaveUserDataAsync (UserData userdata)
        {
            return _database.InsertAsync(userdata);
        }
    }
}

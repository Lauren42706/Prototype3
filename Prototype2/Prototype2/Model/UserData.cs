using SQLite;

namespace Prototype2.Model
{
    public class UserData
    {
        /// <summary>
        /// Sample Data. This can still propbably be used for the final
        /// app.
        /// </summary>

        [PrimaryKey][AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CellNumber { get; set; }
        public string Password { get; set; }
    }
}

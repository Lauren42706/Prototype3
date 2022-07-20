using Prototype2WebApi.Models;

namespace Prototype2WebApi.Data
{
    public class DbInitializer
    {
        private readonly DataContext _context;

        public DbInitializer(DataContext context)
        {
            _context = context;
        }

        public void Run()
        {
            if(!_context.UserInfoDatas.Any())
            {
                var user = new UserInfoData();
                user.FirstName = "Ash";
                user.LastName = "Ketchum";
                user.EmailAddress = "aketchum@pokemon.com";
                user.CellNumber = "0123456789";
                user.Password = "PokemonMasters8";
            }

            if(!_context.FamilyGroups.Any())
            {
                var fam = new FamilyGroup();
            }
        }
    }
}

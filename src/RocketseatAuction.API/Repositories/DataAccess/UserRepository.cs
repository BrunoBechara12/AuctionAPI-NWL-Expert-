using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RocketseatAuctionDbContext _dbcontext;
    public UserRepository(RocketseatAuctionDbContext dbcontext) => _dbcontext = dbcontext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbcontext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbcontext.Users.First(user => user.Email.Equals(email));
}

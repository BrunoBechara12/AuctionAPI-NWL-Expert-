using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbcontext;

    public AuctionRepository(RocketseatAuctionDbContext dbcontext) => _dbcontext = dbcontext;   

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbcontext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}

using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketseatAuctionDbContext _dbcontext;
    public OfferRepository(RocketseatAuctionDbContext dbcontext) => _dbcontext = dbcontext;

    public void Add(Offer offer)
    {
        _dbcontext.Offers.Add(offer);

        _dbcontext.SaveChanges();
    }

    
}

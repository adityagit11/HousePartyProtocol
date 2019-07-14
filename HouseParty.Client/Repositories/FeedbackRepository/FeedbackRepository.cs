using HouseParty.Client.Contracts.Feedbacks;
using HouseParty.Client.DataContext;
using Quditor.Service.UnitOfWork;

namespace HouseParty.Client.Repositories.FeedbackRepository
{
    public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(HousePartyDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}

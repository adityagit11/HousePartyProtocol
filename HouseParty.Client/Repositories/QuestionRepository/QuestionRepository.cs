using HouseParty.Client.Contracts.Questions;
using HouseParty.Client.DataContext;
using Quditor.Service.UnitOfWork;

namespace HouseParty.Client.Repositories.QuestionRepository
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(HousePartyDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}

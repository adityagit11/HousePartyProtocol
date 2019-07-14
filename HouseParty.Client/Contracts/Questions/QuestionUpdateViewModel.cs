using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseParty.Client.Contracts.Questions
{
    public class QuestionUpdateViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Boolean WhetherSeen { get; set; }

        public Boolean WontDo { get; set; }

        public string WontDoReason { get; set; }

        public Boolean WhetherShubhiSubmitted { get; set; }

        public Boolean WhetherAdityaSubmitted { get; set; }

        public string ShubhiSolution { get; set; }

        public string AdityaSolution { get; set; }

        public string QuestionUrl { get; set; }

        public string Notes { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseParty.Client.Contracts.Questions
{
    public class QuestionInputViewModel
    {
        public string Title { get; set; }

        public string QuestionUrl { get; set; }

        public string Notes { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}

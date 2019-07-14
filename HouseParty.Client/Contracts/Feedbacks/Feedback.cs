using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseParty.Client.Contracts.Feedbacks
{
    public class Feedback
    {
        public int Id { get; set; }

        public string FeedbackMessage { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}

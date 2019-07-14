using System;

namespace HouseParty.Client.Contracts.Questions
{
    public class Question
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Boolean WhetherSeen { get; set; }

        public DateTime WhenSeen { get; set; }

        public Boolean WontDo { get; set; }

        public string WontDoReason { get; set; }

        public Boolean WhetherShubhiSubmitted { get; set; }

        public Boolean WhetherAdityaSubmitted { get; set; }

        public string ShubhiSolution { get; set; }

        public string AdityaSolution { get; set; }

        public string QuestionUrl { get; set; }

        public string Notes { get; set; }

        public DateTime QuestionUploaded { get; set; }

        public DateTime ShubhiSolutionSubmittedOn { get; set; }

        public DateTime AdityaSolutionSubmittedOn { get; set; }

        public DateTime ShubhiSolutionUpdatedOn { get; set; }

        public DateTime AdityaSolutionUpdatedOn { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}

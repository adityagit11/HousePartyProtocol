using HouseParty.Client.Contracts.Questions;
using System.Collections.Generic;

namespace HouseParty.Client.Services.QuestionService
{
    public interface IQuestionService
    {
        List<Question> GetQuestions(string userQuestionType);

        int SubmitQuestion(QuestionInputViewModel viewModel);

        void SubmitSolution(QuestionUpdateViewModel viewModel);

        void SubmitShubhiSolution(int questionId);

        void SubmitAdityaSolution(int questionId);

        void WontDoThisQuestion(int questionId);

        int[] GetScore();
    }
}

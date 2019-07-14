using HouseParty.Client.Contracts.Questions;
using HouseParty.Client.Repositories.QuestionRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseParty.Client.Services.QuestionService
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository ?? throw new ArgumentNullException(nameof(questionRepository));
        }

        public List<Question> GetQuestions(string userQuestionType)
        {
            // Get the type of the question
            QuestionType questionType = (QuestionType)Enum.Parse(typeof(QuestionType), userQuestionType);

            var questions = this.questionRepository
                .GetAll(x => x.QuestionType == questionType)
                .OrderBy(x => x.QuestionUploaded)
                .ToList();
            return questions;
        }

        public int SubmitQuestion(QuestionInputViewModel viewModel)
        {
            var question = new Question
            {
                Title = viewModel.Title,
                QuestionUrl = viewModel.QuestionUrl,
                Notes = viewModel.Notes,
                QuestionUploaded = DateTime.UtcNow,
                QuestionType = viewModel.QuestionType
            };

            this.questionRepository.Insert(question);
            this.questionRepository.SaveChanges();

            return question.Id;
        }

        public void SubmitSolution(QuestionUpdateViewModel viewModel)
        {
            var question = this.questionRepository.GetFirstOrDefault(x => x.Id == viewModel.Id);

            if (question == null)
            {
                throw new ArgumentNullException(nameof(viewModel.Id));
            }

            //question.Title = viewModel.Title;

            //// TODO: Update seen status
            //question.WontDo = viewModel.WontDo;
            //question.WontDoReason = viewModel.WontDoReason;

            if (!string.IsNullOrEmpty(viewModel.ShubhiSolution))
            {
                question.WhetherShubhiSubmitted = true;
                question.ShubhiSolution = viewModel.ShubhiSolution;
                question.ShubhiSolutionUpdatedOn = DateTime.UtcNow;
            }


            if (!string.IsNullOrEmpty(viewModel.AdityaSolution))
            {
                question.WhetherAdityaSubmitted = true;
                question.AdityaSolution = viewModel.AdityaSolution;
                question.AdityaSolutionUpdatedOn = DateTime.UtcNow;
            }

            //question.QuestionUrl = viewModel.QuestionUrl;
            //question.Notes = viewModel.Notes;

            //question.QuestionType = viewModel.QuestionType;

            this.questionRepository.Update(question);
            this.questionRepository.SaveChanges();
        }

        public void SubmitShubhiSolution(int questionId)
        {
            var question = this.questionRepository.GetFirstOrDefault(x => x.Id == questionId);

            if (question == null)
            {
                throw new ArgumentNullException(nameof(questionId));
            }

            question.WhetherShubhiSubmitted = true;
            this.questionRepository.Update(question);
            this.questionRepository.SaveChanges();
        }

        public void SubmitAdityaSolution(int questionId)
        {
            var question = this.questionRepository.GetFirstOrDefault(x => x.Id == questionId);

            if (question == null)
            {
                throw new ArgumentNullException(nameof(questionId));
            }

            question.WhetherAdityaSubmitted = true;
            this.questionRepository.Update(question);
            this.questionRepository.SaveChanges();
        }

        public void WontDoThisQuestion(int questionId)
        {
            var question = this.questionRepository.GetFirstOrDefault(x => x.Id == questionId);

            if (question == null)
            {
                throw new ArgumentNullException(nameof(questionId));
            }

            question.WontDo = true;
            this.questionRepository.Update(question);
            this.questionRepository.SaveChanges();
        }

        public int[] GetScore()
        {
            int questionsShubhiSolved = this.questionRepository
                .GetAll(x => x.WhetherShubhiSubmitted == true)
                .Count();

            int questionsAdiSolved = this.questionRepository
                .GetAll(x => x.WhetherAdityaSubmitted == true)
                .Count();

            return new int[] { questionsShubhiSolved, questionsAdiSolved };
        }
    }
}

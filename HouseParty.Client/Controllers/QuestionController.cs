using HouseParty.Client.Contracts.Questions;
using HouseParty.Client.Services.QuestionService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HouseParty.Client.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService ?? throw new ArgumentNullException(nameof(questionService));
        }

        [HttpGet]
        [Route("get/{type}")]
        public List<Question> GetQuestions(string type) => this.questionService.GetQuestions(type);

        [HttpPost]
        [Route("submitquestion")]
        public void SubmitQuestion([FromBody] QuestionInputViewModel viewModel) => this.questionService.SubmitQuestion(viewModel);

        [HttpPut]
        [Route("submitsolution")]
        public void SubmitSolution([FromBody] QuestionUpdateViewModel viewModel) => this.questionService.SubmitSolution(viewModel);

        [HttpGet]
        [Route("submitshubhisolution/{questionId}")]
        public void SubmitShubhiSolution(int questionId) => this.questionService.SubmitShubhiSolution(questionId);

        [HttpGet]
        [Route("submitadityasolution/{questionId}")]
        public void SubmitAdityaSolution(int questionId) => this.questionService.SubmitAdityaSolution(questionId);

        [HttpGet]
        [Route("wontdo/{questionId}")]
        public void WontDoThisQuestion(int questionId) => this.questionService.WontDoThisQuestion(questionId);

        [HttpGet]
        [Route("get/score")]
        public int[] getScore() => this.questionService.GetScore();
    }
}

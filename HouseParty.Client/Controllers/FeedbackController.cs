using HouseParty.Client.Services.FeedbackService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HouseParty.Client.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService ?? throw new ArgumentNullException(nameof(feedbackService));
        }
    }
}

"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var questiontype_model_1 = require("./questiontype.model");
var Question = /** @class */ (function () {
    function Question() {
        this.id = 0;
        this.title = '';
        this.whetherSeen = false;
        this.whenSeen = new Date();
        this.wontDo = false;
        this.wontDoReason = '';
        this.whetherShubhiSubmitted = false;
        this.whetherAdityaSubmitted = false;
        this.shubhiSolution = '';
        this.adityaSolution = '';
        this.questionUrl = '';
        this.notes = '';
        this.questionUploaded = new Date();
        this.shubhiSolutionSubmittedOn = new Date();
        this.adityaSolutionSubmittedOn = new Date();
        this.shubhiSolutionUpdatedOn = new Date();
        this.adityaSolutionUpdatedOn = new Date();
        this.questionType = questiontype_model_1.QuestionType.Others;
    }
    return Question;
}());
exports.Question = Question;
//# sourceMappingURL=question.model.js.map
import { QuestionType } from './questiontype.model';

export class Question {
  id: number = 0;
  title: string = '';
  whetherSeen: boolean = false;
  whenSeen: Date = new Date();
  wontDo: boolean = false;
  wontDoReason: string = '';
  whetherShubhiSubmitted: boolean = false;
  whetherAdityaSubmitted: boolean = false;
  shubhiSolution: string = '';
  adityaSolution: string = '';
  questionUrl: string = '';
  notes: string = '';
  questionUploaded: Date = new Date();
  shubhiSolutionSubmittedOn: Date = new Date();
  adityaSolutionSubmittedOn: Date = new Date();
  shubhiSolutionUpdatedOn: Date = new Date();
  adityaSolutionUpdatedOn: Date = new Date();
  questionType: QuestionType = QuestionType.Others;
}

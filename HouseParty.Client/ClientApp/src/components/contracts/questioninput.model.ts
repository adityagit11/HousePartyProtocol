import { QuestionType } from './questiontype.model';

export class QuestionInput {
  title: string = '';
  questionUrl: string = '';
  notes: string = '';
  questionType: QuestionType;
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Question } from '../contracts/question.model';
import { QuestionInput } from '../contracts/questioninput.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  apiURL: string = 'https://houseparty.azurewebsites.net/api';

  constructor(private httpClient: HttpClient) { }

  getQuestions(questionType: string) {
    return this.httpClient.get<Question[]>(`${this.apiURL}/question/get/` + questionType);
  }

  submitQuestion(questionInput: QuestionInput): Observable<QuestionInput> {
    return this.httpClient.post<QuestionInput>(`${this.apiURL}/question/submitquestion`, questionInput);
  }

  wontDoThisQuestion(questionId: number) {
    return this.httpClient.get(`${this.apiURL}/question/wontdo/` + questionId);
  }

  submitShubhiSolution(questionId: number) {
    return this.httpClient.get(`${this.apiURL}/question/submitshubhisolution/` + questionId);
  }

  submitAdityaSolution(questionId: number) {
    return this.httpClient.get(`${this.apiURL}/question/submitadityasolution/` + questionId);
  }
}

import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Question } from '../contracts/question.model';

@Component({
  selector: 'app-matrix',
  templateUrl: './matrix.component.html',
  styleUrls: ['./matrix.component.css']
})
export class MatrixComponent implements OnInit {
  questions: Question[] = [];

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getQuestions('Matrix').subscribe((res) => {
      this.questions = res;
    });
  }

  wontDoThisQuestion(question: Question) {
    question.wontDo = true;
    this.apiService.wontDoThisQuestion(question.id).subscribe((res) => {
      console.log(res);
    });
  }

  submitShubhiSolution(question: Question) {
    question.whetherShubhiSubmitted = true;
    this.apiService.submitShubhiSolution(question.id).subscribe((res) => {
      console.log(res);
    })
  }

  submitAdityaSolution(question: Question) {
    question.whetherAdityaSubmitted = true;
    this.apiService.submitAdityaSolution(question.id).subscribe((res) => {
      console.log(res);
    })
  }
}

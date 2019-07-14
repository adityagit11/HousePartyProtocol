import { Component, OnInit } from '@angular/core';
import { QuestionInput } from '../contracts/questioninput.model';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-questiondataentry',
  templateUrl: './questiondataentry.component.html',
  styleUrls: ['./questiondataentry.component.css']
})
export class QuestiondataentryComponent implements OnInit {
  questionTypeAr: string[] = [
    'Array',
    'String',
    'Matrix',
    'LinkedList',
    'Stack',
    'Queue',
    'Tree',
    'Hashing',
    'Graph',
    'Others'];
  questionInputObj: QuestionInput = new QuestionInput();

  constructor(private apiService: ApiService) { }

  ngOnInit() {
  }

  submitQuestion() {
    this.apiService.submitQuestion(this.questionInputObj).subscribe(res => {
      console.log(res);
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-scoreboard',
  templateUrl: './scoreboard.component.html',
  styleUrls: ['./scoreboard.component.css']
})
export class ScoreboardComponent implements OnInit {
  shubhiScore: number = 0;
  adiScore: number = 0;

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getScore().subscribe(res => {
      this.shubhiScore = res[0];
      this.adiScore = res[1];
    });
  }
}

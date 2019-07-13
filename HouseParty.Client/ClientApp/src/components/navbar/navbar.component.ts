import { Component, OnInit } from '@angular/core';
import { Config } from 'protractor';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  config: Config = {
    template: '$!h!:$!m!:$!s!'
  }
}

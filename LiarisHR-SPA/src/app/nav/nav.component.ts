import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private router: Router) { }

  ngOnInit() {
  }

  login() {

  }

  loggedIn() {

  }

  logout() {

  }

}
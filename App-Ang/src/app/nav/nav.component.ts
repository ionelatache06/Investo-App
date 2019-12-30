import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any={};

  constructor(private authService:AuthService) { }

  ngOnInit() {
  }

  login(){
    this.authService.login(this.model).subscribe(next=>{
      console.log('The log in was successfull');
    }, error=> {
      console.log('Log in failed')
    });
  }

  loggedin(){
    const token = localStorage.getItem('token');
    return !!token;
    //returns true only if there is somethiing in the token
  }

  logout(){
    localStorage.removeItem('token');
    console.log('loggedout');
  }

}

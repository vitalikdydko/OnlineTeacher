import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
model: any = {};
  constructor() { }

  ngOnInit() {
  }

  // tslint:disable-next-line: typedef
  register(){
    console.log(this.model);
  }

  // tslint:disable-next-line: typedef
  cancel(){
    console.log('Cancelled!');
  }

}

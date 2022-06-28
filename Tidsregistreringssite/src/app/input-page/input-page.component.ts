import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-input-page',
  templateUrl: './input-page.component.html',
  styleUrls: ['./input-page.component.css']
})

export class InputPageComponent implements OnInit {

  //This makes the selector start at the current date
  defaultDate = new Date((new Date().getTime()));

  name: string = '';
  date = "";
  timeUsed = "";
  customerName = "";
  contactPerson = "";
  description = "";
  interDescription = "";

  sendForm(){
    
  }

  constructor() { }
  
  ngOnInit(): void {
  }
  

}

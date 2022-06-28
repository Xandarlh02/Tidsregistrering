import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-input-page',
  templateUrl: './input-page.component.html',
  styleUrls: ['./input-page.component.css']
})

export class InputPageComponent implements OnInit {


  name: string = '';
  date = ""

  constructor() { }
  
  ngOnInit(): void {
  }
  

}

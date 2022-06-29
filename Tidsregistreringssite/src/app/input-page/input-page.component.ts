import { Component, OnInit } from '@angular/core';
import { TidsregService } from 'src/tidsreg.service';
import { Tidsreg } from 'src/classes/tidsreg'
import { FormBuilder, Validators } from '@angular/forms';



@Component({
  selector: 'app-input-page',
  templateUrl: './input-page.component.html',
  styleUrls: ['./input-page.component.css']
})

export class InputPageComponent implements OnInit {

  //This makes the selector start at the current date
  defaultDate = new Date((new Date().getTime()));
  tidsregForm: any;

  date:string;
  timeUsed:number;
  customerName:string;
  contactPerson:string;
  description:string;
  interDescription:string;

  createTidsreg(tidsreg:Tidsreg){
    this.tidsregSerice.createTidsreg(tidsreg)
  }
  submit(){
    const tidsreg = this.tidsregForm.value;
    this.createTidsreg(tidsreg)
    console.log("Hej")
  }

  constructor(private formbulider: FormBuilder, private tidsregSerice:TidsregService) { }

  ngOnInit() {
    this.tidsregForm = this.formbulider.group({
      Date: [''],
      TimeUsed: [''],
      Customer: [''],
      ContactPerson: [''],
      Description: [''],
      InternDescription: [''],
    });
  }


}

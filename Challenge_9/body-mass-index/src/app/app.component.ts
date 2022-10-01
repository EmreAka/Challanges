import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'body-mass-index';
  BMI: FormGroup;
  result: number;
  constructor(private fb: FormBuilder) {
  }

  ngOnInit(): void {
    this.createForm();
    this.BMI.valueChanges.subscribe({
      next: value => {console.log(value);}
    });
  }

  createForm(): void {
    this.BMI = this.fb.group({
      weight: [Validators.required, Validators.min(0)],
      height: [Validators.required, Validators.min(0)]
    });
  }

  calculateBMI(): void{
    let result: number = +this.BMI.controls['weight'].value / ((+this.BMI.controls['height'].value / 100) * (+this.BMI.controls['height'].value / 100));

    this.result = result;
  }

  displayResultString(): string{
    if (!this.result)
      return ""
    else if(this.result < 18.5)
      return "Underweight"
    else if (this.result > 18.5 && this.result < 24.9)
      return "Healthy"
    else
      return "Overweight"
  }

  displayResult(): string{
    if (!this.result)
      return ""
    else if(this.result < 18.5)
      return "../assets/skinny-cat.jpg"
    else if (this.result > 18.5 && this.result < 24.9)
      return "../assets/healthy-cat.jpg"
    else
      return "../assets/heavy-cat.jpg"
  }
}

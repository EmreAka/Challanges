import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {environment} from "../environments/environment";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  city:string;
  weather:any;
  constructor(private httpClient: HttpClient) {
  }
  ngOnInit(): void {
  }

  getWeaterCast(){
    var result = this.httpClient.get(environment.apiUrl+"?key="+environment.apiKey+"&"+"q="+this.city+"&"+"aqi=no").subscribe({
      next: value => {
        console.log(value);
        this.weather = value;
      }
    })
  }
}

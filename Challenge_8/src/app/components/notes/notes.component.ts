import { Component, OnInit } from '@angular/core';
import {NgxIndexedDBService} from "ngx-indexed-db";

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.css']
})
export class NotesComponent implements OnInit {

  notes: any[] = [];

  constructor(private dbService: NgxIndexedDBService) { }

  ngOnInit(): void {
    this.getNotes();
  }
  getNotes(){
    this.dbService.getAll('notes').subscribe({
      next: value => {
        this.notes = value
      },
      error: err => {
        console.log(err);
      }
    });
  }

  deleteNote(key: number){
    console.log(key)
    this.dbService.delete('notes', key).subscribe({
      next: value => {
        console.log("deleted");
        this.notes = value;
      }
    })
  }
}

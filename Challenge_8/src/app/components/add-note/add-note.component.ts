import {Component, OnInit} from '@angular/core';
import {NgxIndexedDBService} from "ngx-indexed-db";

@Component({
  selector: 'app-add-note',
  templateUrl: './add-note.component.html',
  styleUrls: ['./add-note.component.css']
})
export class AddNoteComponent implements OnInit {

  title: string = "";
  note: string = "";
  constructor(private dbService: NgxIndexedDBService) {
  }

  ngOnInit(): void {
  }

  addNote() {
    this.dbService.add('notes', {
      title: `${this.title}`,
      note: `${this.note}`
    }).subscribe({
      next: (value) => {
        this.title = "";
        this.note = "";
      }, error: (err) => {
        console.log(err)
      }
    });
  }
}

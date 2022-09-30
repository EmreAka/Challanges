import {Component, OnInit} from '@angular/core';
import {NgxIndexedDBService} from "ngx-indexed-db";

@Component({
  selector: 'app-add-note',
  templateUrl: './add-note.component.html',
  styleUrls: ['./add-note.component.css']
})
export class AddNoteComponent implements OnInit {

  constructor(private dbService: NgxIndexedDBService) {
  }

  ngOnInit(): void {
  }

  addNote() {
    this.dbService.add('notes', {
      title: `Test`,
      note: `Test note`
    }).subscribe({
      next: (value) => {
        console.log("Success")
      }, error: (err) => {
        console.log(err)
      }
    });
  }
}

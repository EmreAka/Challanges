import {Component, OnInit} from '@angular/core';
import {NgxIndexedDBService} from "ngx-indexed-db";
import {MatSnackBar, MatSnackBarRef, TextOnlySnackBar} from "@angular/material/snack-bar";
import {Router} from "@angular/router";

@Component({
  selector: 'app-add-note',
  templateUrl: './add-note.component.html',
  styleUrls: ['./add-note.component.css']
})
export class AddNoteComponent implements OnInit {

  title: string = "";
  note: string = "";
  constructor(private dbService: NgxIndexedDBService, private snackBar: MatSnackBar, private router: Router) {
  }

  ngOnInit(): void {

  }

  addNote() {
    this.dbService.add('notes', {
      title: `${this.title}`,
      note: `${this.note}`
    }).subscribe({
      next: (value) => {
        let snackBarRef = this.snackBar.open('Note is successfully created!', 'See the notes');
        this.title = "";
        this.note = "";
        snackBarRef.onAction().subscribe(() => {
          this.router.navigateByUrl('/');
        });
      }, error: (err) => {
        console.log(err)
      }
    });
  }
}

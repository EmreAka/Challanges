import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatIconModule} from "@angular/material/icon";
import {MatButtonModule} from "@angular/material/button";
import { ToolbarComponent } from './components/toolbar/toolbar.component';
import { AddNoteComponent } from './components/add-note/add-note.component';
import {MatCardModule} from "@angular/material/card";
import {MatSelectModule} from "@angular/material/select";
import {MatInputModule} from "@angular/material/input";
import {DBConfig, NgxIndexedDBModule} from 'ngx-indexed-db';
import { NotesComponent } from './components/notes/notes.component';
import {FormsModule} from "@angular/forms";

// Ahead of time compiles requires an exported function for factories
export function migrationFactory() {
  // The animal table was added with version 2 but none of the existing tables or data needed
  // to be modified so a migrator for that version is not included.
  return {
    1: (db: any, transaction: { objectStore: (arg0: string) => any; }) => {
      const store = transaction.objectStore('notes');
      store.createIndex('title', 'title', { unique: false });
    },
    2: (db: any, transaction: { objectStore: (arg0: string) => any; }) => {
      const store = transaction.objectStore('notes');
      store.createIndex('note', 'note', { unique: false });
    }
  };
}

const dbConfig: DBConfig  = {
  name: 'NoteAppDb',
  version: 1,
  objectStoresMeta: [{
    store: 'notes',
    storeConfig: { keyPath: 'id', autoIncrement: true },
    storeSchema: [
      { name: 'title', keypath: 'title', options: { unique: false } },
      { name: 'note', keypath: 'note', options: { unique: false } }
    ]
  }],
  migrationFactory
};

@NgModule({
  declarations: [
    AppComponent,
    ToolbarComponent,
    AddNoteComponent,
    NotesComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatSelectModule,
    MatInputModule,
    MatCardModule,
    MatSelectModule,
    NgxIndexedDBModule.forRoot(dbConfig),
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

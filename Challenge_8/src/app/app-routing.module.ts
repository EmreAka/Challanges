import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AddNoteComponent} from "./components/add-note/add-note.component";

const routes: Routes = [
  {path: "add-note", component: AddNoteComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

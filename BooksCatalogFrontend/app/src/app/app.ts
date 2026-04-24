import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BookListComponent } from './components/book-list/book-list.component';
import { BookFormComponent } from "./components/form/book-form/book-form.component";

@Component({
  selector: 'app-root',
  imports: [BookListComponent, BookFormComponent],
  templateUrl: './app.html',
  styles: [],
})
export class App {
  protected readonly title = signal('app');
}

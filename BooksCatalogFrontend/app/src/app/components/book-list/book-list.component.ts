import { Component } from '@angular/core';
import { BookService } from '../../services/book.service';
import { Book } from '../../models/book';

@Component({
  selector: 'app-book-list',
  imports: [],
  templateUrl: './book-list.component.html',
  styles: ``,
})
export class BookListComponent {

  books: Book[] = []

  constructor(private service: BookService) {}

  ngOnInit() {
    this.service.getList().subscribe({
      next: (res) => {
        this.books = res
        console.log(this.books)
      },
      error: (e) => {
        console.log("couldn't complete API call correctly: ", e)
      }
    })
  }
}

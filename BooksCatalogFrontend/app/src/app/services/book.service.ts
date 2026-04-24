import { Injectable } from '@angular/core';
import { Book } from '../models/book'
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookService {

  private apiUrl = "http://localhost:5037/api/books"

  constructor(private http: HttpClient) {}

  getList(): Observable<Book[]> {
    return this.http.get<Book[]>(this.apiUrl)
  }

  postBook(b: Book): Observable<Book> {
    return this.http.post<Book>(this.apiUrl, b)
  }

}

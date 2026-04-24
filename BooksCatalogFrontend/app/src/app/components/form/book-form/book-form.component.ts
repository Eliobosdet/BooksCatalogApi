import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators, ReactiveFormsModule, ValidatorFn, AbstractControl, ValidationErrors } from '@angular/forms';
import { BookService } from '../../../services/book.service';
import { CommonModule } from '@angular/common';
import { Book } from '../../../models/book';

@Component({
  selector: 'app-book-form',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './book-form.component.html',
  styles: ``,
})

export class BookFormComponent {
  
  bookForm = new FormGroup({
    title: new FormControl('', Validators.required),
    author: new FormControl('', Validators.required),
    publicationYear: new FormControl('', [
      Validators.required,
      Validators.minLength(4),
      Validators.maxLength(4),
      Validators.pattern("^[0-9]*$"),
      yearNotFutureValidator()
    ])
  });
  
  constructor(private service: BookService) {}
  
  OnSubmit() {
    if(this.bookForm.valid) {
      const formValue = this.bookForm.value
      
      const newBook: Book = {
        id: 0,
        title: formValue.title!,
        author: formValue.author!,
        publicationYear: Number(formValue.publicationYear)
      }
      console.log(formValue);
      this.service.postBook(newBook).subscribe({
        next: (res) => {
          console.log('Book saved: ', newBook);
          this.bookForm.reset();
        },
        error: (e) => {
          console.log('Error saving book: ', e);
        }
      })
    } else {
      alert("Form is not valid");
    }
  }
  
}

export function yearNotFutureValidator(): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    const currentYear = new Date().getFullYear();
    const inputYear = Number(control.value);
    return inputYear > currentYear ? {futureYear: {value: control.value}} : null
  }
}


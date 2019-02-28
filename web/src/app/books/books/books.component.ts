import { Component, OnInit } from '@angular/core';
import { Book } from '../../books/book';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  book: Book = {
    id: 1,
    title: 'Ready Player One',
    author: 'Ernest Cline'
  };
  
  constructor() { }

  ngOnInit() {
  }

}

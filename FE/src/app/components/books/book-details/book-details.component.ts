import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../../services/api.service';
import { Book } from '../../../models/book.interface';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrl: './book-details.component.scss',
})
export class BookDetailsComponent implements OnInit {
  model: Book = {
    title: '',
    description: '',
    category: '',
    author: ''
  };

  id: number | undefined = undefined;
  constructor(
    private apiService: ApiService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route?.params?.subscribe((params) => {
      this.id = params['id'];
      if (this.id) {
        this.get(this.id);
      }
    });
  }

  get(id: number) {
    this.apiService.GetBook(id).subscribe({
      next: (response: Book) => {
        this.model = response;
      },
      error: (error) => console.error(error),
    });
  }

  save() {
    if (!this.id)
      this.apiService
        .CreateBook(this.model)
        .subscribe({ complete: () => this.router.navigateByUrl('/books') });
    else {
      this.apiService
      .UpdateBook(this.model)
      .subscribe({ complete: () => {
        alert("L'Elemento è stato modificato con successo!");
        this.router.navigateByUrl('/books');
      }});
    }
  }
}

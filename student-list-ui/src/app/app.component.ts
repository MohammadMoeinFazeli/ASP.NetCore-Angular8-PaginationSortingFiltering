import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IStudent, IResult } from './app.interface';
import { NgbdSortableDirective, SortEvent } from './sortable.directive';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  @ViewChildren(NgbdSortableDirective) headers: QueryList<
    NgbdSortableDirective
  >;

  Students: Array<IStudent>;
  page = 1;
  pageSize = 4;
  collectionSize: number;
  searchTerm = '';
  sortDirection = '';
  sortFiled = '';

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.requestData();
  }

  requestData() {
    setTimeout(() => {
      const params = {
        filed: this.sortFiled,
        sortDirection: this.sortDirection,
        term: this.searchTerm,
        page: this.page.toString(),
        pageSize: this.pageSize.toString()
      };
      this.http
        .get<IResult>('http://localhost:60285/api/Student', { params })
        .subscribe(
          result => {
            this.Students = result.results;
            this.page = result.currentPage;
            this.collectionSize = result.rowCount;
            this.pageSize = result.pageSize;
          },
          error => {
            console.log(error);
          }
        );
    });
  }

  onSort({ column, direction }: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.sortDirection = direction;
    this.sortFiled = column;
    this.requestData();
  }
}

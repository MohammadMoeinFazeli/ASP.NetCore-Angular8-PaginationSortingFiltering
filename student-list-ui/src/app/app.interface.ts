export interface IStudent {
  studentId: number;
  name: string;
  family: string;
}

export interface IResult {
  results: Array<IStudent>;
  currentPage: number;
  pageCount: number;
  pageSize: number;
  rowCount: number;
  firstRowOnPage: number;
  lastRowOnPage: number;
}

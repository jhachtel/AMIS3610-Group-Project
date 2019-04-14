import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Gear } from './gear';

@Injectable({
  providedIn: 'root'
})
export class GearService {

  private gearUri = 'https://localhost:5001/api/gear';

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error('${operation} failed: ${error.message}');
      return of(result as T);
    };
  }

  constructor(private http: HttpClient) { }




  getGear() {
    return this.http.get(this.gearUri);
  }

  // getGear() {
  //   return this.http.get<Gear[]>(this.globalUri)
  //   .pipe(tap(_ => console.log('fetched gear')),
  //     catchError(this.handleError<Gear[]>('getGear', []))
  //   );
  // }
}

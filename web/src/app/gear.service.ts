import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { Gear } from './gear';
import { MessageService } from './message.service';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class GearService {

  private gearUrl = 'api/gear';  // URL to web api

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  /** GET gear from the server */
  getAllGear(): Observable<Gear[]> {
    return this.http.get<Gear[]>(this.gearUrl)
      .pipe(
        tap(_ => this.log('fetched gear')),
        catchError(this.handleError('getAllGear', []))
      );
  }

  /** GET gear by id. Return `undefined` when id not found */
  getGearNo404<Data>(id: number): Observable<Gear> {
    const url = `${this.gearUrl}/?id=${id}`;
    return this.http.get<Gear[]>(url)
      .pipe(
        map(gear => gear[0]), // returns a {0|1} element array
        tap(g => {
          const outcome = g ? `fetched` : `did not find`;
          this.log(`${outcome} gear id=${id}`);
        }),
        catchError(this.handleError<Gear>(`getGear id=${id}`))
      );
  }

  /** GET gear by id. Will 404 if id not found */
  getGear(id: number): Observable<Gear> {
    const url = `${this.gearUrl}/${id}`;
    return this.http.get<Gear>(url).pipe(
      tap(_ => this.log(`fetched gear id=${id}`)),
      catchError(this.handleError<Gear>(`getGear id=${id}`))
    );
  }

  /* GET gear whose name contains search term */
  searchGear(term: string): Observable<Gear[]> {
    if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
    }
    return this.http.get<Gear[]>(`${this.gearUrl}/?name=${term}`).pipe(
      tap(_ => this.log(`found gear matching "${term}"`)),
      catchError(this.handleError<Gear[]>('searchGear', []))
    );
  }

  //////// Save methods //////////

  /** POST: add new gear to the server */
  addGear (gear: Gear): Observable<Gear> {
    return this.http.post<Gear>(this.gearUrl, gear, httpOptions).pipe(
      tap((newGear: Gear) => this.log(`added gear w/ id=${newGear.id}`)),
      catchError(this.handleError<Gear>('addGear'))
    );
  }

  /** DELETE: delete the gear from the server */
  deleteGear (gear: Gear | number): Observable<Gear> {
    const id = typeof gear === 'number' ? gear : gear.id;
    const url = `${this.gearUrl}/${id}`;

    return this.http.delete<Gear>(url, httpOptions).pipe(
      tap(_ => this.log(`deleted gear id=${id}`)),
      catchError(this.handleError<Gear>('deleteGear'))
    );
  }

  /** PUT: update the gear on the server */
  updateGear (gear: Gear): Observable<any> {
    return this.http.put(this.gearUrl, gear, httpOptions).pipe(
      tap(_ => this.log(`updated gear id=${gear.id}`)),
      catchError(this.handleError<any>('updateGear'))
    );
  }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  /** Log a GearService message with the MessageService */
  private log(message: string) {
    this.messageService.add(`GearService: ${message}`);
  }
}
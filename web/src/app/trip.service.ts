import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { Trip } from './trip';
import { MessageService } from './message.service';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class TripService {

  private tripsUrl = 'https://off-the-trail.azurewebsites.net/api/trip';  // URL to web api

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  /** GET trips from the server */
  getTrips (): Observable<Trip[]> {
    return this.http.get<Trip[]>(this.tripsUrl)
      .pipe(
        tap(_ => this.log('fetched trips')),
        catchError(this.handleError('getTrips', []))
      );
  }

  /** GET trip by id. Return `undefined` when id not found */
  getTripNo404<Data>(id: number): Observable<Trip> {
    const url = `${this.tripsUrl}/?id=${id}`;
    return this.http.get<Trip[]>(url)
      .pipe(
        map(trips => trips[0]), // returns a {0|1} element array
        tap(h => {
          const outcome = h ? `fetched` : `did not find`;
          this.log(`${outcome} trip id=${id}`);
        }),
        catchError(this.handleError<Trip>(`getTrip id=${id}`))
      );
  }

  /** GET trip by id. Will 404 if id not found */
  getTrip(id: number): Observable<Trip> {
    const url = `${this.tripsUrl}/${id}`;
    return this.http.get<Trip>(url).pipe(
      tap(_ => this.log(`fetched trip id=${id}`)),
      catchError(this.handleError<Trip>(`getTrip id=${id}`))
    );
  }

  /* GET trips whose name contains search term */
  searchTrips(term: string): Observable<Trip[]> {
    if (!term.trim()) {
      // if not search term, return empty trip array.
      return of([]);
    }
    return this.http.get<Trip[]>(`${this.tripsUrl}/?name=${term}`).pipe(
      tap(_ => this.log(`found trips matching "${term}"`)),
      catchError(this.handleError<Trip[]>('searchTrips', []))
    );
  }

  //////// Save methods //////////

  /** POST: add a new trip to the server */
  addTrip (trip: Trip): Observable<Trip> {
    return this.http.post<Trip>(this.tripsUrl, trip, httpOptions).pipe(
      tap((newTrip: Trip) => this.log(`added trip w/ id=${newTrip.id}`)),
      catchError(this.handleError<Trip>('addTrip'))
    );
  }

  /** DELETE: delete the trip from the server */
  deleteTrip (trip: Trip | number): Observable<Trip> {
    const id = typeof trip === 'number' ? trip : trip.id;
    const url = `${this.tripsUrl}/${id}`;

    return this.http.delete<Trip>(url, httpOptions).pipe(
      tap(_ => this.log(`deleted trip id=${id}`)),
      catchError(this.handleError<Trip>('deleteTrip'))
    );
  }

  /** PUT: update the trip on the server */
  updateTrip (trip: Trip): Observable<any> {
    return this.http.put(this.tripsUrl, trip, httpOptions).pipe(
      tap(_ => this.log(`updated trip id=${trip.id}`)),
      catchError(this.handleError<any>('updateTrip'))
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

  /** Log a TripService message with the MessageService */
  private log(message: string) {
    this.messageService.add(`TripService: ${message}`);
  }
}
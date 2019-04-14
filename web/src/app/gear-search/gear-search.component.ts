import { Component, OnInit } from '@angular/core';

import { Observable, Subject } from 'rxjs';

import {
   debounceTime, distinctUntilChanged, switchMap
 } from 'rxjs/operators';

import { Gear } from '../gear';
import { GearService } from '../gear.service';

@Component({
  selector: 'app-gear-search',
  templateUrl: './gear-search.component.html',
  styleUrls: [ './gear-search.component.css' ]
})
export class GearSearchComponent implements OnInit {
  gear$: Observable<Gear[]>;
  private searchTerms = new Subject<string>();

  constructor(private gearService: GearService) {}

  // Push a search term into the observable stream.
  search(term: string): void {
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.gear$ = this.searchTerms.pipe(
      // wait 300ms after each keystroke before considering the term
      debounceTime(300),

      // ignore new term if same as previous term
      distinctUntilChanged(),

      // switch to new search observable each time the term changes
      switchMap((term: string) => this.gearService.searchGear(term)),
    );
  }
}
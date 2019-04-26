import { Component, OnInit } from '@angular/core';
import { Item } from '../item';
import { ItemService } from '../item.service';
import { Person } from '../person';
import { PersonService } from '../person.service';
import { Place } from '../place';
import { PlaceService } from '../place.service';
import { Trip } from '../trip';
import { TripService } from '../trip.service';
import { Trail } from '../trail';
import { TrailService } from '../trail.service';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  items: Item[] = [];
  persons: Person[] = [];
  places: Place[]=[];
  trips: Trip []=[];
  trails: Trail[]=[];

  constructor(private ItemService: ItemService, PersonService: PersonService, PlaceService: PlaceService, TripService: TripService, TrailService: TrailService) { }

  ngOnInit() {
    this.getItem();
    // this.getPerson();
    // this.getPlace();
    // this.getTrip();
    // this.getTrail();
    
  }
  getItem(): void {
    this.ItemService.getItems()
      .subscribe(item => this.items = item.slice(1, 5));
  }
  // getPerson (): void {
  //   this.PersonService.getPeople()
  //     .subscribe(person => this.persons = person.slice(1, 5));
  // }
  // getPlace (): void {
  //   this.PlaceService.getPlaces()
  //     .subscribe(place => this.places = place.slice(1, 5));
  // }
  // getTrip (): void {
  //   this.TripService.getTrips()
  //     .subscribe(trip => this.trips = trip.slice(1, 5));
  // }
  // getTrail(): void {
  //   this.TrailService.getTrails()
  //     .subscribe(trail => this.trails = trail.slice(1, 5));
  // }
}


import { Component, OnInit } from '@angular/core';

import { Trip } from '../trip';
import { TripService } from '../trip.service';

@Component({
  selector: 'app-trips',
  templateUrl: './trips.component.html',
  styleUrls: ['./trips.component.css']
})
export class TripsComponent implements OnInit {
  trips: Trip[];

  constructor(private TripService: TripService) { }

  ngOnInit() {
    this.getTrips();
  }

  getTrips(): void {
    this.TripService.getTrips()
    .subscribe(trips => this.trips = trips);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.TripService.addTrip({ name } as Trip)
      .subscribe(trip => {
        this.trips.push(trip);
      });
  }

  delete(trip: Trip): void {
    this.trips = this.trips.filter(i => i !== trip);
    this.TripService.deleteTrip(trip).subscribe();
  }

}
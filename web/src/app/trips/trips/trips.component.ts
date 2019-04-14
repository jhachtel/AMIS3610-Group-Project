import { Component, OnInit } from '@angular/core';
import { Trip } from '../Trip';
import { Place } from 'src/app/places/Place';
import { Gear } from 'src/app/gear/Gear';
import { People } from 'src/app/people/People';

@Component({
  selector: 'app-trips',
  templateUrl: './trips.component.html',
  styleUrls: ['./trips.component.css']
})
export class TripsComponent implements OnInit {

  trip: Trip = {
    id: 1,
    name: 'trip1',
    place: new Place,
    gear: new Gear,
    people: new People,
    blog: 'hdjdjdddddd'
}

  constructor() { }

  ngOnInit() {
  }

}

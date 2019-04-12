import { Component, OnInit } from '@angular/core';
import { Place } from '../Place';

@Component({
  selector: 'app-places',
  templateUrl: './places.component.html',
  styleUrls: ['./places.component.css']
})
export class PlacesComponent implements OnInit {


   place: Place = {
    id: 1,
    country: 'United States',
    state: 'Ohio',
    city: 'Columbus',
    park: 'Olentangy Trail',
    restaurant: 'Traditions at Scott',
    lodging: 'Starbucks',
    attraction: 'Ohio State University'
}
  constructor() { }

  ngOnInit() {
  }

}

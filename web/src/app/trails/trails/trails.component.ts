import { Component, OnInit } from '@angular/core';
import { Trail } from '../Trail';
import { Place } from 'src/app/places/Place';

@Component({
  selector: 'app-trails',
  templateUrl: './trails.component.html',
  styleUrls: ['./trails.component.css']
})
export class TrailsComponent implements OnInit {

  trail: Trail = {
    id: 1,
    name: 'Olentangy Trail',
    place: new Place
}
  constructor() { }

  ngOnInit() {
  }

}

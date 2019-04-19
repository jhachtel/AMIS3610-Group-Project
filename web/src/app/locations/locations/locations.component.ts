import { Component, OnInit } from '@angular/core';
import { Location } from "../Location";

@Component({
  selector: 'app-locations',
  templateUrl: './locations.component.html',
  styleUrls: ['./locations.component.css']
})
export class LocationsComponent implements OnInit {


  location: Location = {
     
      country: 'USA',
      city: 'Columbus',
      park: 'Olentangy Trail',
      hostel: 'OSU Bench'

  };
  constructor() { }

  ngOnInit() {
  }

}

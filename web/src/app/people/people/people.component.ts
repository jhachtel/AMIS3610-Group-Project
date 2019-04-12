import { Component, OnInit } from '@angular/core';
import { People } from '../People'

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {

  person: People = {
    id: 1,
    name: 'Alex Tetzloff',
    contactinfo: '5136128261',
    bio: 'Hey whats up homie lets get ready to trailblaze'
  }
  constructor() { }

  ngOnInit() {
  }

}

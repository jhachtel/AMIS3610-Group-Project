import { Component, OnInit } from '@angular/core';

import { Person } from '../people';
import { PeopleService } from '../people.service';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {
  people: Person[];

  constructor(private peopleService: PeopleService) { }

  ngOnInit() {
    this.getPeople();
  }

  getPeople(): void {
    this.peopleService.getPeople()
    .subscribe(people => this.people = people);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.peopleService.addPerson({ name } as Person)
      .subscribe(person => {
        this.people.push(person);
      });
  }

  delete(person: Person): void {
    this.people = this.people.filter(p => p !== person);
    this.peopleService.deletePerson(person).subscribe();
  }

}
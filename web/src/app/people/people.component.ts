import { Component, OnInit } from '@angular/core';

import { Person } from '../person';
import { PersonService } from '../person.service';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {
  people: Person[];

  constructor(private PersonService: PersonService) { }

  ngOnInit() {
    this.getPeople();
  }

  getPeople(): void {
    this.PersonService.getPeople()
    .subscribe(people => this.people = people);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.PersonService.addPerson({ name } as Person)
      .subscribe(person => {
        this.people.push(person);
      });
  }

  delete(person: Person): void {
    this.people = this.people.filter(p => p !== person);
    this.PersonService.deletePerson(person).subscribe();
  }

}
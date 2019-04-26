import { NgModule }           from '@angular/core';
import { PeopleComponent } from './people/people.component';
import { AppRoutingModule } from './app-routing.module';

import { PersonService } from './person.service';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [PeopleComponent],
    declarations: [PeopleComponent],
    providers: [ PersonService ],
 })
 
 export class PersonModule {
 }
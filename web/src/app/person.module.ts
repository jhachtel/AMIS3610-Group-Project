import { NgModule }           from '@angular/core';
import { PeopleComponent } from './people/people.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    imports: [
        AppRoutingModule
    ],
    exports: [PeopleComponent],
    declarations: [PeopleComponent],
    providers: [],
 })
 
 export class PersonModule {
 }
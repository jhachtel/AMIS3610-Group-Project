import { NgModule }           from '@angular/core';
import { BrowserModule }      from '@angular/platform-browser';
import { FormsModule }        from '@angular/forms';
import { HttpClientModule }   from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LocationsComponent } from './locations/locations/locations.component';
import { GearComponent } from './gear/gear/gear.component';
import { PeopleComponent } from './people/people/people.component';
import { PlacesComponent } from './places/places/places.component';
import { TrailsComponent } from './trails/trails/trails.component';
import { TripsComponent } from './trips/trips/trips.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { GearDetailComponent } from './gear-detail/gear-detail.component';
import { GearSearchComponent } from './gear-search/gear-search.component';
import { MessagesComponent } from './messages/messages.component';

@NgModule({
  
  declarations: [
    AppComponent,
    GearComponent,
    PeopleComponent,
    PlacesComponent,
    TrailsComponent,
    TripsComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    DashboardComponent,
    GearComponent,
    GearDetailComponent,
    MessagesComponent,
    GearSearchComponent,
    NavbarComponent
  ],
  bootstrap: [ AppComponent ]
})

export class AppModule {

}

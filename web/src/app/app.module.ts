import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LocationsComponent } from './locations/locations/locations.component';
import { ActivitiesComponent } from './activities/activities/activities.component';
import { GearComponent } from './gear/gear/gear.component';
import { PeopleComponent } from './people/people/people.component';
import { PlacesComponent } from './places/places/places.component';
import { TrailsComponent } from './trails/trails/trails.component';
import { TripsComponent } from './trips/trips/trips.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LocationsComponent,
    ActivitiesComponent,
    GearComponent,
    PeopleComponent,
    PlacesComponent,
    TrailsComponent,
    TripsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

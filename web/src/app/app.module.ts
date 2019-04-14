import { NgModule }           from '@angular/core';
import { BrowserModule }      from '@angular/platform-browser';
import { FormsModule }        from '@angular/forms';
import { HttpClientModule }   from '@angular/common/http';

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
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule

    // The HttpClientInMemoryWebApiModule module intercepts HTTP requests
    // and returns simulated server responses.
    // Remove it when a real server is ready to receive requests.
    // HttpClientInMemoryWebApiModule.forRoot(
    //   InMemoryDataService, { dataEncapsulation: false }
    // )
  ],
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
    DashboardComponent,
    GearComponent,
    GearDetailComponent,
    MessagesComponent,
    GearSearchComponent,
    NavbarComponent
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
<<<<<<< HEAD
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
=======
import { NgModule }           from '@angular/core';
import { BrowserModule }      from '@angular/platform-browser';
import { FormsModule }        from '@angular/forms';
import { HttpClientModule }   from '@angular/common/http';
>>>>>>> 788af3af0e31c255cf396ec4df604cfd2f8aa66c

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { GearComponent } from './gear/gear/gear.component';
import { PeopleComponent } from './people/people/people.component';
import { PlacesComponent } from './places/places/places.component';
import { TrailsComponent } from './trails/trails/trails.component';
import { TripsComponent } from './trips/trips/trips.component';
import { NavbarComponent } from './navbar/navbar.component';

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
    GearComponent,
    PeopleComponent,
    PlacesComponent,
    TrailsComponent,
    TripsComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
<<<<<<< HEAD
    AppRoutingModule, HttpClientModule
=======
    AppRoutingModule
    DashboardComponent,
    GearComponent,
    GearDetailComponent,
    MessagesComponent,
    GearSearchComponent,
    NavbarComponent
>>>>>>> 788af3af0e31c255cf396ec4df604cfd2f8aa66c
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
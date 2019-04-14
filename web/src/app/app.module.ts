import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

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
    AppRoutingModule, HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

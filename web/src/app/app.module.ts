import { NgModule }           from '@angular/core';
import { BrowserModule }      from '@angular/platform-browser';
import { FormsModule }        from '@angular/forms';
import { HttpClientModule, HttpClient }   from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MessagesComponent } from './messages/messages.component';

import { ItemsComponent } from './items/items.component';
import { PeopleComponent } from './people/people.component';
import { PlacesComponent } from './places/places.component';
import { TrailsComponent } from './trails/trails.component';
import { TripsComponent } from './trips/trips.component';

import { ItemDetailComponent } from './item-detail/item-detail.component';
import { PersonDetailComponent } from './person-detail/person-detail.component';
import { PlaceDetailComponent } from './place-detail/place-detail.component';
import { TrailDetailComponent } from './trail-detail/trail-detail.component';
import { TripDetailComponent } from './trip-detail/trip-detail.component';

import { ItemSearchComponent } from './item-search/item-search.component';
import { PersonSearchComponent } from './person-search/person-search.component';
import { PlaceSearchComponent } from './place-search/place-search.component';
import { TrailSearchComponent } from './trail-search/trail-search.component';
import { TripSearchComponent } from './trip-search/trip-search.component';

@NgModule({
  imports: [
    AppRoutingModule,
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
    MessagesComponent,
    NavbarComponent,
	
	ItemsComponent,
	PeopleComponent,
	PlacesComponent,
	TrailsComponent,
	TripsComponent,
	
	ItemDetailComponent,
	PersonDetailComponent,
	PlaceDetailComponent,
	TrailDetailComponent,
	TripDetailComponent,
	
	ItemSearchComponent,
	PersonSearchComponent,
	PlaceSearchComponent,
	TrailSearchComponent,
	TripSearchComponent
  ],
  bootstrap: [ AppComponent ]
})

export class AppModule {

}

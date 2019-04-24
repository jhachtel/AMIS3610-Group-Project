import { NgModule }           from '@angular/core';
import { BrowserModule }      from '@angular/platform-browser';
import { FormsModule }        from '@angular/forms';
import { HttpClientModule }   from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ItemsComponent } from './items/items.component';
import { PeopleComponent } from './people/people.component';
import { PlacesComponent } from './places/places.component';
import { TrailsComponent } from './trails/trails.component';
import { TripsComponent } from './trips/trips.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ItemDetailComponent } from './item-detail/item-detail.component';
import { ItemSearchComponent } from './item-search/item-search.component';
import { MessagesComponent } from './messages/messages.component';

@NgModule({
  
  declarations: [
    AppComponent,
    ItemsComponent,
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
    ItemsComponent,
    ItemDetailComponent,
    MessagesComponent,
    ItemSearchComponent,
    NavbarComponent
  ],
  bootstrap: [ AppComponent ]
})

export class AppModule {

}

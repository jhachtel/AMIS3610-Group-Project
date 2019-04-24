import { NgModule }           from '@angular/core';
import { BrowserModule }      from '@angular/platform-browser';
import { FormsModule }        from '@angular/forms';
import { HttpClientModule, HttpClient }   from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ItemModule } from './item.module';
import { PersonModule } from './person.module';
import { PlaceModule } from './place.module';
import { TrailModule } from './trail.module';
import { TripModule } from './trip.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MessagesComponent } from './messages/messages.component';

@NgModule({
  imports: [
    AppRoutingModule,
    BrowserModule,
    FormsModule,
    HttpClientModule,
    DashboardComponent,
    MessagesComponent,
    NavbarComponent,
    ItemModule,
    PersonModule,
    PlaceModule,
    TrailModule,
    TripModule
  ],
  declarations: [
    AppComponent
  ],
  bootstrap: [ AppComponent ]
})

export class AppModule {

}

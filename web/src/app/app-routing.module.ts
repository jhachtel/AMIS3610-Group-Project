import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent }   from './dashboard/dashboard.component';
import { ItemsComponent }      from './items/items.component';
import { PeopleComponent }      from './people/people.component';
import { PlacesComponent }      from './places/places.component';
import { TrailsComponent }      from './trails/trails.component';
import { TripsComponent }      from './trips/trips.component';
import { ItemDetailComponent }  from './item-detail/item-detail.component';
import { PersonDetailComponent }  from './person-detail/person-detail.component';
import { PlaceDetailComponent }  from './place-detail/place-detail.component';
import { TrailDetailComponent }  from './trail-detail/trail-detail.component';
import { TripDetailComponent }  from './trip-detail/trip-detail.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'items', component: ItemsComponent },
  { path: 'items/:id', component: ItemDetailComponent },
  { path: 'person', component: PeopleComponent },
  { path: 'person/:id', component: PersonDetailComponent },
  { path: 'places', component: PlacesComponent },
  { path: 'places/:id', component: PlaceDetailComponent },
  { path: 'trails', component: TrailsComponent },
  { path: 'trails/:id', component: TrailDetailComponent },
  { path: 'trips', component: TripsComponent },
  { path: 'trips/:id', component: TripDetailComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [RouterModule]
})
export class AppRoutingModule { }

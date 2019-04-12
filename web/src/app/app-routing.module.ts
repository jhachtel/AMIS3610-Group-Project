import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { TripsComponent } from './trips/trips/trips.component';
import { TrailsComponent } from './trails/trails/trails.component';
import { GearComponent } from './gear/gear/gear.component';
import { PeopleComponent } from './people/people/people.component';
import { PlacesComponent } from './places/places/places.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent},
  { path: 'gear', component: GearComponent },
  { path: 'people', component: PeopleComponent},
  { path: 'places', component: PlacesComponent},
  { path: 'trails', component: TrailsComponent},
  { path: 'trips', component: TripsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

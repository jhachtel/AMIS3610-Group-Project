import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GearComponent }       from './gear/gear/gear.component';
import { HomeComponent }        from './home/home.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'gear', component: GearComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [RouterModule]
})

export class AppRoutingModule { }

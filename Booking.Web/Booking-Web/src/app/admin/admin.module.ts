import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CountryMasterComponent } from './country-master/country-master.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    CountryMasterComponent,
    DashboardComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class AdminModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CountryMasterComponent } from './country-master/country-master.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouterModule } from '@angular/router';
import { CountryComponent } from './country/country.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CountryMasterComponent,
    DashboardComponent,
    CountryComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule
  ]
})
export class AdminModule { }

import { Component, OnInit } from '@angular/core';
import { CountryService } from '../service/country.service';
import { Country } from '../models/country';

@Component({
  selector: 'app-country-master',
  templateUrl: './country-master.component.html',
  styleUrls: ['./country-master.component.css']
})
export class CountryMasterComponent implements OnInit {

  countries:Country[]=[];
  constructor(private countryService:CountryService) { }

  ngOnInit(): void {
    this.getAll();
  }


  getAll(){
    this.countryService.getAll().subscribe(
      (response:Country[])=>{
          this.countries=response;
      }
    )
  }

}

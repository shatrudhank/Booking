import { Component, OnInit } from '@angular/core';
import { Country } from '../models/country';
import { CountryService } from '../service/country.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.css']
})
export class CountryComponent implements OnInit {
  country:Country=new Country();
  constructor(private countryService:CountryService,private router:Router) { }

  ngOnInit(): void {
  }

  add(){
    this.countryService.add(this.country).subscribe( 
      (response:any)=>{
        this.router.navigate(['admin-dashboard/admin-country']);
      },
      (error)=>{
        alert(error);
      }
    );
  }
}

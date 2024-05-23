import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Country } from '../models/country';

@Injectable({
  providedIn: 'root'
})
export class CountryService {
  urlPrefix: string = "http://localhost:5103/api/country/";
  constructor(private httpClient:HttpClient) { }

  getAll():Observable<Country[]>
  {
    return this.httpClient.get<Country[]>(this.urlPrefix + "getCountries");
  }
  add(country:Country):Observable<any>
  {
    return this.httpClient.post<Country>(this.urlPrefix + "add",country);
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PlayerService {

  private url = "https://localhost:5001/players/"
  constructor(private http: HttpClient) { }
}

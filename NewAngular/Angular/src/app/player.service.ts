import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Player } from './shared/Player';


@Injectable({
  providedIn: 'root'
})
export class PlayerService {

  private url = "https://localhost:5001/players"

  constructor(private http:HttpClient) { }



//public data: Player;

  public getPlayers(): Observable<any> {
    return this.http.get(this.url);
  }


}


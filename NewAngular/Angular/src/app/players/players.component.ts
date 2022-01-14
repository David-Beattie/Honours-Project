import { Component, OnInit } from '@angular/core';
import { PlayerService } from '../player.service';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.css']
})
export class PlayersComponent implements OnInit {

public players: any;
  constructor(private service:  PlayerService ) { }

  ngOnInit(): void {
    this.getPlayers();
  }

  private getPlayers(): void {
    this.service.getPlayers().subscribe(result =>{
      this.players = result;

    });
  }

}

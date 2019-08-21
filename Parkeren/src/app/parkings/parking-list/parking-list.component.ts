import { Component, OnInit } from '@angular/core';
import Parking from '../../models/parking';

@Component({
  selector: 'app-parking-list',
  templateUrl: './parking-list.component.html',
  styleUrls: ['./parking-list.component.scss']
})
export class ParkingListComponent implements OnInit {

  parkings:Parking[];

  constructor() { }

  loadParkings():void{
    this.parkings = new Array<Parking>();
    this.parkings.push(new Parking(
      1,
      "Vrijdagmarkt",
      "Vrijdagmarkt",
      true,
      300,
      500,
      "Vrijdagmarkt 12"
    ));

    this.parkings.push(new Parking(
      1,
      "Reep",
      "Reep",
      true,
      100,
      500,
      "Vrijdagmarkt 14"
    ));

    this.parkings.push(new Parking(
      1,
      "Zuid",
      "Zuid",
      true,
      300,
      500,
      "Vrijdagmarkt 16"
    ));

    this.parkings.push(new Parking(
      1,
      "Poel",
      "Poel",
      true,
      300,
      500,
      "Vrijdagmarkt 18"
    ));
  }

  ngOnInit() {
    this.loadParkings();
  }

}

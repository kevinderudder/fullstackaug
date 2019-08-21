import { Component, OnInit, Input } from '@angular/core';
import Parking from '../../models/parking';

@Component({
  selector: 'app-parking-details',
  templateUrl: './parking-details.component.html',
  styleUrls: ['./parking-details.component.scss']
})
export class ParkingDetailsComponent implements OnInit {

  /*parking:Parking = new Parking(
    1,
    "Vrijdagmarkt",
    "Vrijdagmarkt",
    true,
    300,
    500,
    "Vrijdagmarkt 12"
  );*/

  @Input() parking:Parking;


  constructor() { }

  ngOnInit() {
  }

}

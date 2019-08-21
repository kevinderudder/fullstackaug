import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ParkingDetailsComponent } from './parkings/parking-details/parking-details.component';
import { ParkingListComponent } from './parkings/parking-list/parking-list.component';

@NgModule({
  declarations: [
    AppComponent,
    ParkingDetailsComponent,
    ParkingListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

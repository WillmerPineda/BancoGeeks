import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
 
import {HttpClientModule} from "@angular/common/http";
import { ValuesComponent } from './values/values.component';
import {ServiciAPIBancoGeeks} from './Servicios/ServicioBancoGeeks.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxSpinnerModule } from "ngx-spinner";

@NgModule({
  declarations: [
    AppComponent,
    ValuesComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    HttpClientModule, FormsModule,
    ReactiveFormsModule,
    NgxSpinnerModule
  ],
  providers: [ServiciAPIBancoGeeks],
  bootstrap: [AppComponent]
})
export class AppModule { }

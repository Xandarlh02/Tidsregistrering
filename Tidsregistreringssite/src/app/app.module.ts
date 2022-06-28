import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InputPageComponent } from './input-page/input-page.component';

//Material
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { OverviewPageComponent } from './overview-page/overview-page.component';

@NgModule({
  declarations: [
    AppComponent,
    InputPageComponent,
    OverviewPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,

    //Material
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
  ],
  exports: [
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

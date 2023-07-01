import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { LandingModule } from './landing/landing.module';
import { SharedModule } from './shared/shared.module';
import { AppRoutingModule } from './app-routing.module';
import { AppNavbarComponent } from './app-navbar/app-navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SideNavModule } from './side-nav/side-nav.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AppNavbarComponent,
    SharedModule,
    SideNavModule,
    LandingModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

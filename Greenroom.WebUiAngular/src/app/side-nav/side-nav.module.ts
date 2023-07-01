import { MatSidenavModule } from '@angular/material/sidenav';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SideNavComponent } from './side-nav.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    SideNavComponent,
  ],
  imports: [
    SharedModule,
    MatSidenavModule,
  ],
  exports: [
    SideNavComponent,
    MatSidenavModule,
  ]
})
export class SideNavModule { }

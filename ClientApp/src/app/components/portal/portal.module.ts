import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule,ReactiveFormsModule  } from '@angular/forms';

import { RefreshAppsComponent } from './refresh-apps/refresh-apps.component';
import { PortalRoutingModule } from './portal-routing.module';

@NgModule({
  declarations: [RefreshAppsComponent],
  imports: [
    CommonModule,
    PortalRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class PortalModule { }

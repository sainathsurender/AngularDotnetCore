import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RefreshAppsComponent } from './refresh-apps/refresh-apps.component';

const routes: Routes = [{ path: 'RefreshApps', component: RefreshAppsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PortalRoutingModule { }

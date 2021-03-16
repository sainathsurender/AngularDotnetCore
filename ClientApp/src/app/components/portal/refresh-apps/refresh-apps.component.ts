import { Component } from '@angular/core';
import { RefreshAppDTO } from 'src/app/shared/classes/refresh-app-dto';
import { HttpService } from 'src/app/shared/services/http.service';

@Component({
  selector: 'app-refresh-apps',
  templateUrl: './refresh-apps.component.html',
  styleUrls: ['./refresh-apps.component.css']
})
export class RefreshAppsComponent {

  input: RefreshAppDTO = new RefreshAppDTO(); 
  _applications: any;
  _environments: any;

  constructor(private httpService: HttpService){
    this.httpService.GetServices<any>('RefreshApps/GetApplications').subscribe(result => {
      this._applications = result;
    });

    this.httpService.GetServices<any>('RefreshApps/GetEnvironments').subscribe(result => {
      this._environments = result;
    });
  }

  submitForm() {
    this.httpService.PostData('RefreshApps/RefreshApp',this.input).subscribe(result => {
      this._applications = result;
    });
  }

}

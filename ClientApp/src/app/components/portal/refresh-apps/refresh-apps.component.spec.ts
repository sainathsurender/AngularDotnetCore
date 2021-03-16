import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RefreshAppsComponent } from './refresh-apps.component';

describe('RefreshAppsComponent', () => {
  let component: RefreshAppsComponent;
  let fixture: ComponentFixture<RefreshAppsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RefreshAppsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RefreshAppsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

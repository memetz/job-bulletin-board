import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CandidateComponent } from './candidate/candidate.component';
import { CandidateService } from './services/candidate.service';
import { JobService } from './services/job.service';
import { AddSkillComponent } from './add-skill/add-skill.component';
import { JobComponent } from './job/job.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CandidateComponent,
    AddSkillComponent,
    JobComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'candidate', component: CandidateComponent },
      { path: 'job', component: JobComponent },
    ])
  ],
  providers: [CandidateService, JobService],
  bootstrap: [AppComponent]
})
export class AppModule { }

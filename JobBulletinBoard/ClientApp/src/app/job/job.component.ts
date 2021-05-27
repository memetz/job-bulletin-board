import { Component, OnInit } from '@angular/core';
import { Job } from '../Model/Job';
import { JobService } from '../services/job.service';
import { switchMap } from 'rxjs/operators';

const EMPTY_JOB: Job = {
  id: 0,
  name: null,
  company: null,
  skills: []
};

@Component({
  selector: 'app-job',
  templateUrl: './job.component.html',
  styleUrls: ['./job.component.css']
})
export class JobComponent implements OnInit {

  jobs: Job[] = [];
  newJob: Job = {
    ...EMPTY_JOB
  };

  constructor(private jobService: JobService) { }

  ngOnInit() {
    this.jobService.getJobs().subscribe(res => {
      this.handleJobs(res);
    }, error => console.error(error));
  }

  addJob(){
    this.jobService.postJob(this.newJob).pipe(
      switchMap( () => this.jobService.getJobs())
    ).subscribe(res => {
      this.handleJobs(res);
      this.newJob = {
        ...EMPTY_JOB
      };
    }, error => console.error(error));
  }

  handleJobs(jobs: Job[]){
    this.jobs = [...jobs];
  }

}

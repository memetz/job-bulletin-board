import { Injectable, Inject } from '@angular/core';
import { Job } from '../Model/Job';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class JobService {

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getJobs() {
    return this.http.get<Job[]>(`${this.baseUrl}api/job`);
  }

  postJob(job: any) {
    return this.http.post<Job>(`${this.baseUrl}api/job`, job);
  }

}

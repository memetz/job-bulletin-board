import { Injectable, Inject } from '@angular/core';
import { Candidate } from '../Model/Candidate';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class CandidateService {

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getCandidates() {
    return this.http.get<Candidate[]>(`${this.baseUrl}api/candidate`);
  }

  postCandidates(candidate: any) {
    return this.http.post<Candidate>(`${this.baseUrl}api/candidate`, candidate);
  }

}

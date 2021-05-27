import { Component, OnInit } from '@angular/core';
import { CandidateService } from '../services/candidate.service';
import { Candidate } from '../Model/Candidate';
import { switchMap } from 'rxjs/operators';

const EMPTY_CANDIDATE: Candidate = {
  id: 0,
  name: null,
  surname: null,
  title: null,
  skills: []
};

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {

  candidates: Candidate[] = [];
  newCandidate: Candidate = {
    ...EMPTY_CANDIDATE
  };

  constructor(private candidateService: CandidateService) { }

  ngOnInit() {
    this.candidateService.getCandidates().subscribe(res => {
      this.handleCandidates(res);
    }, error => console.error(error));
  }

  addCandidate(){
    this.candidateService.postCandidates(this.newCandidate).pipe(
      switchMap( () => this.candidateService.getCandidates())
    ).subscribe(res => {
      this.handleCandidates(res);
      this.newCandidate = {
        ...EMPTY_CANDIDATE
      };
    }, error => console.error(error));
  }

  handleCandidates(candidates: Candidate[]){
    this.candidates = [...candidates];
  }

}

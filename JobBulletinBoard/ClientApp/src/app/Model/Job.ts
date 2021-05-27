import { Candidate } from "./Candidate";

export interface Job {
  id: number;
  name: string;
  company: string;
  skills: string[];
  bestCandidate?: Candidate
}

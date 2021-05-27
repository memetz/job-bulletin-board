import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-add-skill',
  templateUrl: './add-skill.component.html',
  styleUrls: ['./add-skill.component.css']
})
export class AddSkillComponent implements OnInit {
  @Input()
  get skills() {
    return this.skillsValue;
  }
  set skills(value: string[]) {
    this.skillsValue = value;
    this.skillsChange.emit(this.skillsValue);
  }
  skillsValue: string[];

  @Output()
  skillsChange: EventEmitter<string[]> = new EventEmitter();

  newSkill: string;

  constructor() { }

  ngOnInit() {
  }

  add(){
    if (this.newSkill && this.indexOf(this.skillsValue, this.newSkill) === -1){
      this.skillsValue.push(this.newSkill);
      this.skillsChange.emit(this.skillsValue);
      this.newSkill = null;
    }
  }

  remove(skill: string){
    this.skillsValue = this.skillsValue.filter(e => e !== skill);
    this.skillsChange.emit(this.skillsValue);
  }

  indexOf = (arr, q) => arr.findIndex(item => q.toLowerCase() === item.toLowerCase());

}

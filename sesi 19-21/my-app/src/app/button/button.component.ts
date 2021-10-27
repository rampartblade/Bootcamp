import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {

  @Input()name =''
  newMsg = ''
  @Output() clickEventHandler = new EventEmitter()

  onButtonClick(){
    
    this.clickEventHandler.emit()
  }

  constructor() { }

  ngOnInit(): void {
  }

}

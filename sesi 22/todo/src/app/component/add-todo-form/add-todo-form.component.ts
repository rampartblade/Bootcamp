import { templateJitUrl } from '@angular/compiler';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent implements OnInit {
  @Output() newTodoEvent = new EventEmitter<Todo>();

  //inputTodo:string="";

  form: {
    inputData: FormGroup
    errors: any
  } = {
    inputData: new FormGroup({
      inputTodo: new FormControl('',[
        Validators.required,
        Validators.minLength(3)
      ])
    }),
    errors: {}
  }

  
  get inputTodo () {
    return this.form.inputData.get('inputTodo')
  }

  validateForm () {
    if(this.inputTodo?.errors)
      this.form.errors.inputTodo = { ...this.inputTodo?.errors }
    else
      delete this.form.errors.inputTodo
  }

  addTodo(){
    /* if(this.inputTodo.length == 0)
    {
      alert("Input tidak boleh kosong!")
      return
    } */

    this.validateForm()

    if(Object.keys(this.form.errors).length === 0) {
      const todo: Todo = {
        content: this.inputTodo?.value,
        completed: false,
        status: false,
      };
      this.newTodoEvent.emit(todo)
    }
    /* const todo: Todo = {
      content: this.inputTodo?.value,
      completed: false,
      status: false,
    }; */

    //this.inputTodo = "";
    console.log(this.form.inputData.get('inputTodo'))
  }

  constructor() { }

  ngOnInit(): void {
  }

}

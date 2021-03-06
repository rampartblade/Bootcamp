import { Component, OnInit } from '@angular/core';
import { Todo } from 'src/app/models/Todo';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todos:Todo[]= [];
  blank: string = "???";
  inputTodo: string="";

  constructor() { }

  ngOnInit(): void {
    this.todos = [
      {
        content: 'First todo',
        completed: false,
        status: false,
      },
      {
        content: 'Second todo',
        completed: false,
        status: false,
      }
    ]
  }

/*   form: {
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
  } */


  toggleDone (id:number) {
    this.todos.map((v, i) =>{
      if(i == id) v.completed =! v.completed;
      //console.log(v)
      //console.log(i)
      return v;
    })
  }

  deleteTodo (id:number) {
    this.todos = this.todos.filter((v,i) => i !== id);
  }

  editTodo(id:number){
    this.todos.map((v, i) =>{
      if(i == id)
      { 
        v.status =! v.status;
        //v.content == this.inputTodo;
        //console.log(v.content.length)
        /* this.validateForm();
        if(Object.keys(this.form.errors).length === 0) {
          v.content = this.inputTodo?.value
        } */
        if(v.content.length == 0){
          alert('Todo list cannot be empty')
          v.status = true;
          //console.log(v.content.length)
        }
        else if(v.content.length < 3){
          alert('Todo list should have a minimum of 3 character(s).')
          v.status = true;
        }
      }
      //console.log(this.inputTodo)
      return v;
    })
    
  }

  addTodo(todo: Todo) {
    this.todos.push(todo);
  }

}

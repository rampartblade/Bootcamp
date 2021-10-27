import { Component, OnInit } from '@angular/core';
import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todos:Todo[]= [];
  inputTodo: string="";
  blank: string = "???";

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
        console.log(v.content.length)
        if(v.content.length == 0){
          alert('Unknown Input!')
          //console.log(v.content.length)
          return v.content = this.blank
        }
      }
      console.log(v)
      return v;
    })
    
  }

  addTodo(todo: Todo) {
    this.todos.push(todo);
  }

}

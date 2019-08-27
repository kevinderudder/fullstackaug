import { COMPLETE_TODO, DELETE_TODO, ADD_TODO } from './../actions';
import { Component, OnInit } from '@angular/core';
import { IAppState } from '../store';
import { NgRedux, select } from '@angular-redux/store';
import { ITodo } from '../itodo';
import { Title } from '@angular/platform-browser';
@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.scss']
})
export class TodoListComponent implements OnInit {

  @select() todos;
  model:ITodo={
    id: 0,
    title:  '',
    description: '',
    isCompleted: false
  }
  constructor(private ngRedux: NgRedux<IAppState>) { }

  ngOnInit() {
  }

  onSubmit(){
    this.ngRedux.dispatch({type: ADD_TODO, todo:this.model});
  }

  completeTodo(todo){
    this.ngRedux.dispatch({type: COMPLETE_TODO, id: todo.id});
  }

  deleteTodo(todo){
    this.ngRedux.dispatch({type: DELETE_TODO, id: todo.id});
  }

}

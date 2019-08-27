import { ITodo } from './itodo';
import { ADD_TODO, DELETE_ALL_TODOS, DELETE_TODO, COMPLETE_TODO} from './actions';
export interface IAppState{
    todos: ITodo[];
}

export const INITIAL_STATE: IAppState = {
    todos:[]
}

// reducer = state + action --> new state

export function rootReducer(state, action){
    switch(action.type){
        case ADD_TODO:
            action.todo.id = state.todos.length +  1;
            return Object.assign({}, state, {
                todos: state.todos.concat(Object.assign({}, action.todo))
            });
        case COMPLETE_TODO:
            let todotje = state.todos.find(t => t.id === action.id);
            let index = state.todos.indexOf(todotje);
            return Object.assign({}, state, {
                todos: [...state.todos.slice(0, index),
                        Object.assign({}, todotje, {isCompleted: true}),
                        ...state.todos.slice(index +1)]
            });   
        
        case DELETE_TODO: return Object.assign({}, state, {
            todos: state.todos.filter(t => t.id !== action.id)
        });
        case DELETE_ALL_TODOS:return Object.assign({}, state, {
            todos:[]
        });
    }
    return state;
}
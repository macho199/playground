import React from "react";

type TodoListProps = {
  todos: string[];
  delTodo: (index: number) => void;
};

const TodoList = ({ todos, delTodo }: TodoListProps) => {
  return (
    <ul>
      {todos.length > 0 &&
        todos.map((todo, i) => {
          return <li key={i}>{i}{' '}{todo}{' '}<button onClick={(e) => delTodo(i)}>삭제</button></li>;
        })}
    </ul>
  );
};

export default TodoList;

import React, { useState } from "react";
import AddButton from "./components/AddButton";
import TodoList from "./components/TodoList";
import AddInput from "./components/AddInput";

const App = (): React.ReactNode => {
  const [keyword, setKeyword] = useState<string>('');
  const [todos, setTodos] = useState<string[]>([]);

  const addTodo = () => {
    setTodos((prev) => [...prev, keyword]);
  }

  const delTodo = (index: number) => {
    setTodos(prev => prev.filter((todo, i) => {
      return i !== index;
    }))
  }
  
  return (
    <div>
      <AddInput keyword={keyword} setKeyword={setKeyword} addTodo={addTodo} />
      <AddButton addTodo={addTodo}>추가</AddButton>
      <TodoList todos={todos} delTodo={delTodo} />
    </div>
  );
};

export default App;

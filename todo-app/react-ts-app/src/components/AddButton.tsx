import React from "react";

type AddButtonProps = {
  addTodo: () => void;
  children: string;
};

const AddButton = ({ addTodo, children }: AddButtonProps) => {
  return <button onClick={addTodo}>{children}</button>;
};

export default AddButton;

import React from "react";

type AddInputProps = {
  keyword: string;
  setKeyword: (a: string) => void;
  addTodo: () => void;
};

const AddInput = ({ keyword, setKeyword, addTodo }: AddInputProps) => {
  const handleKeyDown = (e: React.KeyboardEvent<HTMLInputElement>) => {
    if (e.key === 'Enter') {
      addTodo();
      setKeyword('');
    }
  };

  return (
    <input
      type="text"
      onChange={(e) => setKeyword(e.target.value)}
      onKeyDown={handleKeyDown}
      value={keyword}
    />
  );
};

export default AddInput;

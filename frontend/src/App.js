import React from 'react';
import Todo from "./Components/Todo.js";
import Nav from "./Components/Navigation.js";
import './App.css';
import './style.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Nav />
        <Todo />

      </header>
    </div>
  );
}

export default App;

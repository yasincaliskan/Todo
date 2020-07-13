import React from 'react';
import Todo from "./Components/Todo.js";
import Nav from "./Components/Nav.js";
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Todo />
        <br></br>
        <Nav />

      </header>
    </div>
  );
}

export default App;

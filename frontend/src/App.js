import React from 'react';
import Todo from "./Components/Todo.js";
import Login from "./Components/Login.js";
import Register from "./Components/Register.js";
import './App.css';
import './Components/style.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Login />
        <Register />
        {/* <Todo /> */}

      </header>
    </div>
  );
}

export default App;

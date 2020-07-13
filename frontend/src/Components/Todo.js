import React, { useState, useEffect } from 'react';
// import './style.css';


function Todo() {

  const [error, setError] = useState(null);
  const [isLoaded, setIsLoaded] = useState(false);
  const [items, setItems] = useState([]);

  // Note: the empty deps array [] means
  // this useEffect will run once
  // similar to componentDidMount()
  useEffect(() => {
    fetch("https://localhost:44367/api/todo")
      .then(res => res.json())
      .then(
        (result) => {
          setIsLoaded(true);
          setItems(result);
        },
        // Note: it's important to handle errors here
        // instead of a catch() block so that we don't swallow
        // exceptions from actual bugs in components.
        (error) => {
          setIsLoaded(true);
          setError(error);
        }
      )
  }, [])

  return (

    <div>
      <table>
        <thead>
          <tr>
            <th>#</th>
            <th>Todo</th>
            <th>Description</th>
            <th>Status</th>
          </tr>
        </thead>


        {items.map(item => (
          <tbody key={item.id}>
            <tr>
              <td>{item.id}</td>
              <td>{item.title}</td>
              <td>{item.description}</td>
              <td>{item.isDone === true ? "Done" : "Not Completed"} </td>
            </tr>
          </tbody>
        ))}


      </table>
    </div>

  );
}


export default Todo;

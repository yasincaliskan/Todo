import React, { useState, useEffect } from 'react';
import { useForm } from "react-hook-form";


function Todo() {

  const [items, setItems] = useState([]);

  useEffect(() => {
    fetch("https://localhost:44367/api/todo/all")
      .then(res => res.json())
      .then(
        (result) => {
          setItems(result);
        },
      )
  }, [])

  function isChecked() {

  }

  const [title, setTitle] = useState('');
  const [description, setDescription] = useState('');

  const onSubmit = data => {

    fetch('https://localhost:44367/api/todo', {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json',

      },
      body: JSON.stringify({
        title: title,
        description: description
      })
    })
  }

  return (

    <div>
      <form>
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
                <td>{item.isDone === true ? <input type="checkbox" checked onChange={isChecked} /> : <input type="checkbox" onChange={isChecked} />}</td>
              </tr>
            </tbody>
          ))}

          <tbody>
            <tr>
              <td>Add/Update</td>
              <td><input onChange={e => setTitle(e.target.value)} name="title"></input></td>
              <td><input onChange={e => setDescription(e.target.value)} name="description"></input></td>
              <td><button style={{ background: "green" }} onClick={onSubmit}>OK</button></td>
            </tr>
          </tbody>

        </table>
      </form>
    </div >

  );
}

export default Todo;
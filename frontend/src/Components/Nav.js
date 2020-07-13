import React from "react";
import './style.css';

function Nav() {
  return (
    <div className="divider">
      <button style={{background:"green"}}>Add</button>
      <button style={{background:"orange"}}>Update</button>
      <button style={{background:"red"}}>Delete</button>
    </div>
  )
}
export default Nav;
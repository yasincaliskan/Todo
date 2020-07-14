import React from 'react';
import Login from "./Login";
import Register from "./Register";
import './style.css';


function Home() {

    return (
        <div>
            <h2>Welcome to ToDo!</h2>
            <button style={{ background: "green" }} type="button">Sign In</button>
            <button style={{ background: "orange" }}>Sign Up</button>
        </div>
    )


}

export default Home;
import React, { useState } from 'react';
import Login from "./Login";
import Register from "./Register";
import './style.css';
import todologo from "../logo.png"



function Home() {

    const [nav, setNav] = useState('login');

    const buttonHandler = (navState) => {
        setNav(navState);
    }

    return (
        <div>
            <img src={todologo} className="Image"/>
            <h2>Welcome to To-Do!</h2>



            {nav === 'login' ?
                <div>
                    <Login />
                    <small>You have not an account?  <a style={{ textDecoration: 'underline' , color: 'red'}} onClick={() => buttonHandler('register')}>Sign Up</a> </small>
                </div> :
                <div>
                    <Register />
                    <small>You have an account? <a style={{ textDecoration: 'underline' , color: 'red'}} onClick={() => buttonHandler('login')}>Sign In</a> </small>
                </div>}
        </div>
    )


}

export default Home;
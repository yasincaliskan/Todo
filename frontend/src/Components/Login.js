import React from 'react';

function Login() {
    return (
        <div>
            <form>
                <table>
                    <thead>
                        <tr>
                            <th>Username</th>
                            <th>Password</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><input></input></td>
                            <td><input type="password"></input></td>
                            <td><button style={{ background: "green" }}>Sign In</button></td>
                        </tr>
                    </tbody>
                </table>
            </form>
            
        </div>
    )
}

export default Login;
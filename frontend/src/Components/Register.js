import React from 'react';

function Register() {
    return (
        <div>
            <form>
                <table>
                    <tbody>
                        <tr>
                            <td>Username</td>
                            <td><input></input></td>
                        </tr>

                        <tr>
                            <td>Email</td>
                            <td><input></input></td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td><input type="password"></input></td>
                        </tr>
                        <tr>
                            <td>Password Again*</td>
                            <td><input type="password"></input></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><button style={{ background: "green" }}>Sign Up</button></td>
                        </tr>
                    </tbody>
                </table>
            </form>
        </div>
    )
}

export default Register;
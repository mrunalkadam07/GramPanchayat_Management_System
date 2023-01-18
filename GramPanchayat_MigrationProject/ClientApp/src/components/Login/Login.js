import React, {useState} from "react";
import LoginServices from "../../Services/LoginServices";


const services = new LoginServices();
export const Login = (props) => {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [message, setMessage] = useState("");
    
    // const emailRegex = /^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*$/

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(email);
        document.getElementById("error-message").innerHTML = ""
        if(email === "" && password === "")
        {
            alert("Enter Username and Password");
            console.log("Input fields are Empty");
            return
        }
        console.log("Data : ",email,password);
        const data = {
            user : email,
            pass : password
        }
        services.LoginModel(data).then((data)=>{
            console.log(data)
        }).catch((error)=>{
            console.log(error)
        })
    }
    return (
        <>
        <div className="auth-form-container">
            <h3>Login</h3>
            <form className = "login-form" onSubmit = {handleSubmit}>
                <label htmlFor="email">User</label>
                <input value = {email} onChange={(e) => setEmail(e.target.value)} type = "text" placeholder="Enter User" id = "email" name = "email"></input>
                <label htmlFor="password">password</label>
                <input value = {password} onChange={(e) => setPassword(e.target.value)}type = "password" placeholder="********" id = "password" name = "password"></input>
                <button type = "submit">Log in</button>
            </form>
            <br/>
            <div id="error-message"></div>

            <button className = "link-btn" onClick={() => props.onFormSwitch('register')}>Don't have an account? Register here!</button>
        </div>
        </> 
    )
}
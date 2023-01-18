import axios from "axios"


export default class LoginAxiosServices{
    post(url,data,Header){
        console.log("In Axios");
        return axios.post(url,data,Header).then((response)=>{
        if(response.status===200)
        {
            alert("Logged In Successfully")
        }
        else{
            alert("Invalid Credentials")
        }
        })
    }
}

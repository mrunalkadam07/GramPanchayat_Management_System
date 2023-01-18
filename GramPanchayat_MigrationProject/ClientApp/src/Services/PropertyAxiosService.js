import axios from "axios"


export default class PropertyAxiosServices{
    post(url,data,Header){
        console.log("In Axios");
        return axios.post(url,data,Header).then((response)=>{
        if(response.status===200)
        {
            alert("Data Added Successfully")
        }
        else{
            alert("Invalid Credentials")
        }
        })
    }
}

import Configuration from "../Configuration/Configuration";
import AxiosServices from "./LoginAxiosServices";

const axios = new AxiosServices();

export default class LoginServices{
    LoginModel(data){
        console.log("data : ",data,"Url : ",Configuration.LoginModel)
        return axios.post(Configuration.LoginModel,data,false)
    }
}
import React, {useState} from "react";
import PropertyTaxServices from "../../Services/PropertyTaxService";

const services = new PropertyTaxServices();

export const PropertyTaxPaidForm = (props) => {
    // const [billNo, setBillNo] = useState('');
    const [billDate, setBillDate] = useState('');
    const [year, setYear] = useState("");
    const [name, setName] = useState("");
    const [address, setAddress] = useState("");
    const [propertyNo, setPropertyNo] = useState("");
    const [homeTax, setHomeTax] = useState("");
    const [electricityTax, setElectricityTax] = useState("");
    const [specialWaterTax, setSpecialWaterTax] = useState("");
    const [educationalsess, setEducationalsess] = useState("");
    const [penaltyCharge, setPenaltyCharge] = useState("");
    const [total, setTotal] = useState("");

    const addPropertyTax = (e) =>{
        e.preventDefault();
        if(billDate === "" && year==="" && name==="" && address==="" &&
         propertyNo==="" && homeTax==="" && electricityTax==="" && specialWaterTax==="" && 
         educationalsess==="" && penaltyCharge==="" && total==="")
        {
            alert("Enter all the required input Fields")
            console.log("Input fields are Empty");
            return
        }
        console.log("Data : ",billDate,year,name,address,propertyNo,homeTax,electricityTax,specialWaterTax,educationalsess,penaltyCharge,total);
        const data = {
            billdate : billDate,
            year : year,
            name : name,
            address : address,
            propertyNo : propertyNo,
            homeTax : homeTax,
            electrycityTax : electricityTax,
            specialWaterTax : specialWaterTax,
            educationalSess : educationalsess,
            panaltyCharge : penaltyCharge,
            total : total
        }
        services.PropertyTaxPaid(data).then((data)=>{
            console.log(data)
        }).catch((error)=>{
            console.log(error)
        })
    }

    return(
        <>
            <h1 align="center">Property Tax Paid Form</h1>
            <form className="row g-3">
                <div className="leftdiv">
                    <div className="col-md-6">
                        <label htmlFor="inputBillDate" className="form-label">Bill Date :-&#62; </label>
                        <input value = {billDate} onChange={(e) => setBillDate(e.target.value)} type="Date" className="form-control" id="inputBillDate" />
                    </div>
                    {/* <div className="col-md-6">
                        <label htmlFor="inputBillNo" className="form-label">Bill No. :-&#62; </label>
                        <input value = {billNo} onChange={(e) => setBillNo(e.target.value)} type="text" className="form-control" id="inputBillNo"/>
                    </div> */}
                    <div className="col-md-6">
                        <label htmlFor="inputName" className="form-label"><br/>Name :-&#62; </label>
                        <input value = {name} onChange={(e) => setName(e.target.value)} type="text" className="form-control" id="inputName"/>
                    </div>
                    <div className="col-md-6">
                        <label htmlFor="inputAddress" className="form-label">Address :-&#62; </label>
                        <input value = {address} onChange={(e) => setAddress(e.target.value)} type="text" className="form-control" id="inputAddress"/>
                    </div>
                    <div className="col-md-4">
                        <label htmlFor="inputHomeTax" className="form-label">Home Tax :-&#62; </label>
                        {/* <select id="inputHomeTax" className="form-selected">
                        <option defaultValue={"Select"}>Choose...</option>
                        </select> */}
                        <input value = {homeTax} onChange={(e) => setHomeTax(e.target.value)} type="text" className="form-control" id="inputHomeTax"/>
                    </div>
                    <div className="col-md-6">
                        <label htmlFor="inputElectricityTax" className="form-label">Electricity Tax :-&#62; </label>
                        {/* <select id="inputElectricityTax" className="form-selected">
                        <option defaultValue={"Select"}>Choose...</option>
                        </select> */}
                        <input value = {electricityTax} onChange={(e) => setElectricityTax(e.target.value)} type="text" className="form-control" id="inputElectricityTax"/>
                    </div>
                    <div className="col-md-6">
                        <label htmlFor="inputSpecialWaterTax" className="form-label">Special Water Tax :-&#62; </label>
                        {/* <select id="inputSpecialWaterTax" className="form-selected">
                        <option defaultValue={"Select"}>Choose...</option>
                        </select> */}
                        <input value = {specialWaterTax} onChange={(e) => setSpecialWaterTax(e.target.value)}type="text" className="form-control" id="inputSpecialWaterTax"/>
                    </div>
                    <div className="col-md-6">
                        <label htmlFor="inputEducationalSess" className="form-label">Educational Sess :-&#62; </label>
                        {/* <select id="inputEducationalSess" className="form-selected">
                        <option defaultValue={"Select"}>Choose...</option>
                        </select> */}
                        <input value = {educationalsess} onChange={(e) => setEducationalsess(e.target.value)} type="text" className="form-control" id="inputEducationalSess"/>
                    </div>
                    <div className="col-md-6">
                        <label htmlFor="inputPenaltyCharge" className="form-label">Penalty Charge :-&#62; </label>
                        {/* <select id="inputPenaltyCharge" className="form-selected">
                        <option defaultValue={"Select"}>Choose...</option>
                        </select> */}
                        <input value = {penaltyCharge} onChange={(e) => setPenaltyCharge(e.target.value)} type="text" className="form-control" id="inputPenaltyCharge"/>
                    </div> 
                    <div className="col-md-6">
                        <label htmlFor="inputTotal" className="form-label">Total :-&#62; </label>
                        <input value = {total} onChange={(e) => setTotal(e.target.value)} type="text" className="form-control" id="inputTotal"/>
                    </div>
                    <div className="col-12"><br/>
                        <button type="ADD" className="btn btn-primary" onClick={addPropertyTax}>ADD </button> &nbsp;&nbsp;
                        {/* <button type="SAVE" className="btn btn-primary">SAVE </button> &nbsp;&nbsp; */}
                        <button type="MODIFY" className="btn btn-primary">MODIFY </button> &nbsp;&nbsp;
                        <button type="DELETE" className="btn btn-primary">DELETE </button> &nbsp;&nbsp;
                        <button type="CANCEL" className="btn btn-primary">CANCEL </button> &nbsp;&nbsp;
                        {/* <button type="FIRST" className="btn btn-primary">FIRST </button> &nbsp;&nbsp;
                        <button type="LAST" className="btn btn-primary">LAST </button> &nbsp;&nbsp;
                        <button type="NEXT" className="btn btn-primary">NEXT </button> &nbsp;&nbsp;
                        <button type="PREVIOUS" className="btn btn-primary">PREVIOUS </button> &nbsp;&nbsp; */}
                        <button type="EXIT" className="btn btn-primary">EXIT</button>
                    </div>
                </div>
                <div className="rightdiv">
                    <div className="col-md-6">
                        <label htmlFor="inputYear" className="form-label">Year :-&#62; </label>
                        <input value = {year} onChange={(e) => setYear(e.target.value)} type="number" placeholder="yyyy" min="1947" max="2023" className="form-control" id="inputYear"/>
                    </div>
                    <div className="col-md-6">
                        <label htmlFor="inputPropertNo" className="form-label">Propert No. :-&#62; </label>
                        <input value = {propertyNo} onChange={(e) => setPropertyNo(e.target.value)}  type="text" className="form-control" id="inputPropertNo"/>
                    </div>
                </div>
            </form>
        </>
    )
}

using System;

namespace AddressContainer{
    public class Address{
    public string firstname;
    public string lastname;
    public string address;
    public string city;
    public string state;
    public int zip;
    public long phonenumber;
    public string email;

    public Address(string firstname,string lastname,string address,string city,string state,int zip ,long phonenumber,string email){
        this.firstname =firstname;
        this.lastname = lastname;
        this.address =address;
        this.city=city;
        this.state =state;
        this.zip= zip;
        this.phonenumber = phonenumber;
        this.email=email;
    }
    public override string ToString()
{
    return $"{firstname} {lastname}, {address}, {city}, {state} {zip}, {phonenumber}, {email}";
}


}
}
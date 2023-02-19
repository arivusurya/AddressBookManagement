using System;
using AddressContainer;
using System.Collections.Generic;

namespace AddressBookContainer{


    public class AddressBook{
        public List<AddressContainer.Address> addresses;

        public AddressBook(){
            addresses = new List<AddressContainer.Address>();
        }
        

        public void DisplayAlluser(){
        foreach (Address address in addresses){
            Console.WriteLine(address.ToString());
        }
        }

        public void Adduser(Address newAddress){
            addresses.Add(newAddress);
            
        }
        public void EditUser(string name,Address updatedAddress ){
            Address obj =addresses.FirstOrDefault(x=>x.firstname == name);
            if(obj != null){
            int index =addresses.IndexOf(obj);
          
            addresses[index] = updatedAddress;
            }else{
                Console.WriteLine("No object found on this name");
            }
        }


    }

}
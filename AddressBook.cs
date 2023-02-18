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


    }

}
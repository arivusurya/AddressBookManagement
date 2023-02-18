using System;
using AddressContainer;
using AddressBookContainer;
using System.Collections.Generic;
namespace AddressManagement{

    class Program{
        public static void Main(string[] args){
            AddressBook addressBook = new AddressBook();
            Address myaddress = new Address("Monkey.D.","Luffy","567 hello world in open","opensourceforest","GrandLine",600001,9884849929,"monkeydluffy@onepice.com");
            Address myaddress1 = new Address("Ronoro Zoro.","Luffy","567 hello world in open","opensourceforest","GrandLine",600001,9884849929,"monkeydluffy@onepice.com");
          
            addressBook.Adduser(myaddress);
            addressBook.Adduser(myaddress1);
            addressBook.DisplayAlluser();
        }
    }

}

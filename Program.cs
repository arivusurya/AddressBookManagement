using System;
using AddressContainer;
using AddressBookContainer;
using System.Collections.Generic;
namespace AddressManagement{

    class Program{
       
        public static void Main(string[] args){
            AddressBook addressBook = new AddressBook();
            Address address;
          

            while(true){
                Options();
                addressBook.DisplayAlluser();
            
            }
            
            void PersonalDetails(){
                Console.Write ("Firstname : ");
                 string firstname = Console.ReadLine();
                Console.Write("lastname : ");
                string lastname =Console.ReadLine();
                Console.Write("Address : ");
                string personaddress = Console.ReadLine();
                Console.Write("city : ");
                string city = Console.ReadLine();
                Console.Write("state : ");
                string state = Console.ReadLine();
                Console.Write("Zip : ");
                int zip = Convert.ToInt32(Console.ReadLine());
                Console.Write("Phone Number  : ");
                long phonenumber = (long)Convert.ToUInt64(Console.ReadLine());
                Console.Write("email  : ");
                string email =Console.ReadLine();
                address = new Address(firstname,lastname,
                personaddress,city,state,zip,phonenumber,email);
                
            }

            void Options(){
                Console.WriteLine("Enter the Option : " );
                Console.WriteLine("1. Add User" );
                Console.WriteLine("2. Edit User" );
                Console.WriteLine("3. Delete User" );
                string option  = Console.ReadLine();
                if (option == "Add User" | option == "1" | option == "adduser"){
                    PersonalDetails();
                    addressBook.Adduser(address);
                   
                }else if(option == "Edit User" | option == "2" | option == "edituser" ){
                    Console.WriteLine("enter the name");
                    string name = Console.ReadLine();
                    PersonalDetails();
                    addressBook.EditUser(name,address);
                }else if(option == "Delete User " | option == "3" | option == "deleteuser"){
                    Console.WriteLine("Enter the Name");
                    string Name = Console.ReadLine();
                    addressBook.deleteUser(Name);
                }else{
                    Console.WriteLine("Enter the right Option ");
                }

            }
            // addressBook.Adduser(address);
            
        }
    }

}

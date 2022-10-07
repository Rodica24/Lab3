using System;

namespace VScode{
    
    class Program{

        static void Main(){
            Hotel hotel = new Hotel();
            Menu menu = new Menu();
            Orders orders = new Orders();
            Chief chief = new Chief("Luidji", "Chief");
            Cleaners cleaners = new Cleaners("Galea", "Cleaner");
            Administrator administrator = new Administrator("Mihai", "Administrator");

        
    
            hotel.setValues("Grand", "Chisinau");
            hotel.printValues();

            Rooms rooms = new Rooms();
            rooms.GenerateRoom();

            Facility facility = new Facility();
            facility.displayFacility();

          
            menu.displayMain();
            menu.displayDrink();

            
            orders.orderMain();
            orders.orderDrink();
            

            Client client = new Client();

        
            chief.prepare(orders);
            cleaners.cleanRoom();

            Console.WriteLine();
            administrator.speak();
            chief.speak();
            cleaners.speak();


           
        }

    } 

}
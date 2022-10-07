using System;

namespace VScode{

    class Facility{
        private KeyValuePair<string, int> facility;

        public void displayFacility(){

            Dictionary<string, int> Drink_menu = new Dictionary<string, int>(){
                                                                                {"Taxi", 100},
                                                                                {"Cleaner", 10}};
                                                                           

            Console.WriteLine();
            Console.WriteLine("Provided facilities:");
            
            foreach(KeyValuePair<string, int> el in Drink_menu){
                Console.WriteLine("{0} - {1}", el.Key, el.Value);
            }
            
            Console.WriteLine();

        }
    }   
}

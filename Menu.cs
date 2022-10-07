using System;
using System.Collections.Generic;
using System.Linq;

namespace VScode{

    class Menu: Hotel {
        
        public Dictionary<string, int> Main_menu { get; set; }
        public Dictionary<string, int> Drink_menu { get; set; }
        
  

        public void displayMain(){

            Dictionary<string, int> Main_menu = new Dictionary<string, int>(){
                                                                                {"Burger and fries", 110},
                                                                                {"Caesar Salad", 90},
                                                                                {"Pasta Bolognese", 100}};  

            Console.WriteLine();
            Console.WriteLine("Room main menu:");
            
            foreach(KeyValuePair<string, int> el in Main_menu){                
                Console.WriteLine("{0} - {1}", el.Key, el.Value);
            }

        }

        

        public void displayDrink(){

            Dictionary<string, int> Drink_menu = new Dictionary<string, int>(){
                                                                                {"Sparkling water", 20},
                                                                                {"Coca-cola", 30},
                                                                                {"Juices", 35}};

            Console.WriteLine();
            Console.WriteLine("Room drink menu:");
            
            foreach(KeyValuePair<string, int> el in Drink_menu){
                Console.WriteLine("{0} - {1}", el.Key, el.Value);
            }
            
            Console.WriteLine();

        }
    }   
}
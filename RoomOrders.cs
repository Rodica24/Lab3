using System;

namespace VScode{

    class Orders{
        private KeyValuePair<string, int> main;
        private KeyValuePair<string, int> drink;



        public KeyValuePair<string, int> orderMain(){
            Random random = new Random();
            Dictionary<string, int> dictionary = new Dictionary<string, int>(){
                                                                                {"Burger and fries", 110},
                                                                                {"Caesar Salad", 90},
                                                                                {"Pasta Bolognese", 100}};  


            int index = random.Next(dictionary.Count);

            string key = dictionary.Keys.ElementAt(index);
            int value = dictionary.Values.ElementAt(index);

            KeyValuePair<string, int> main = dictionary.ElementAt(index);
            return main;
        }

        

        public KeyValuePair<string, int> orderDrink(){

            Random random = new Random();
            Dictionary<string, int> dictionary = new Dictionary<string, int>(){
                                                                                {"Sparkling water", 20},
                                                                                {"Coca-cola", 30},
                                                                                {"Juices", 35}};  

            int index = random.Next(dictionary.Count);

            string key = dictionary.Keys.ElementAt(index);
            int value = dictionary.Values.ElementAt(index);

            KeyValuePair<string, int> drink = dictionary.ElementAt(index);
            return drink;
        }
    }


       
}
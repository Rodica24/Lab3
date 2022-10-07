using System;

namespace VScode{

    class Hotel{

        private string name;

        private string adress;


        

        public void setValues(string _name, string _adress){
            name = _name;
            adress = _adress;
        }

        public void printValues(){
            System.Console.WriteLine("Welcome to the hotel " + name + " from " + adress);
        }
    }
}
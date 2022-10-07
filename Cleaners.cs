using System;

namespace VScode{

    class Cleaners: Personal{
       private Client client;

       public Cleaners(string name, string status): base(name, status){
            setValues(name, status);
        }

       public void cleanRoom(){
            Random rnd = new Random();
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("There are this number of dirty rooms:");
                Console.WriteLine(rnd.Next(3));//returns random integers < 10
                }

        }}}

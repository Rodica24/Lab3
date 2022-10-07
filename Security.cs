using System;

namespace VScode{

    class Security: Personal{
       private Client client;

         public Security(string name, string status): base(name, status){
            setValues(name, status);
        }

       public void goHome(Client client){
            if (client.tips < -5){
            }
            
            else if (client.tips > 10){
            }
       }
    }
}
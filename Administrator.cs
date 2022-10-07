using System;

namespace VScode{

    class Administrator: Personal{
        private Client client;

        public Administrator(string name, string status): base(name, status){
            setValues(name, status);
        }
        
       public override void speak(){
       base.speak();
       Console.WriteLine("How can I help you?");
       }

        public void grade(Client client, Cleaners cleaners){
            Console.WriteLine("");
            if (client.Tips <= 0){

                Console.WriteLine("The waiter now has a lower salary(");
            }
            else if (client.Tips > 0){
                Console.WriteLine("The waiter gets congrats");
            }
        }

    }
}
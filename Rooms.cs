using System;

namespace VScode{
    class Rooms: Hotel{
        private string available;

        private int quality;

        private int number;

        public void GenerateRoom(){
            Random rnd = new Random();
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("There are this number of free rooms:");
                Console.WriteLine(rnd.Next(10));//returns random integers < 10
                }


        }

        public int Quality{
            get { return this.quality; }
            set { this.quality = value; } 
        }

        public int room(Client client){
            Random rand = new Random();
            this.quality = rand.Next(1, 3);
            return  this.quality;
        }

        public void RoomQuality(int quality, Client client){
            if (this.quality == 0){
                client.tips -= 1;
                Console.WriteLine("This room is clean");
            }

            else if (quality == 1){
                client.tips -= 2;
                Console.WriteLine("This room is dirty");
            }

    }}}
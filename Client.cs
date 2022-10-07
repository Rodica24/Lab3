using System; 

namespace VScode{

    class Client{
        private int money;
        public int tips ;
       

        public int Money{
            get { return money; }
            set { money = value; }
        }      

        
        public int Tips{
            get { return tips; }
            set { tips = value; }
        }     

    
        public int RemTips(int tips){
            money -= tips;
            return tips;
        }


    }
}
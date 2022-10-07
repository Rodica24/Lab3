using System;

namespace VScode{
    class Personal: Hotel{

        public string name;
        private int workExperience;
        protected string status;
        private int salary;

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public int WorkExperience { 
            get { return workExperience; }
            set { workExperience = value; }
        }

    

        public string Status{
            get { return status; }
            set { status = value; }
        }

        public int Salary{
            get { return salary; }
            set { salary = value; }
        }

        public Personal(string name, string status){
            setValues(name, status);
        }

        new public void setValues(string name, string status){
            this.name = name;
            this.status = status;
        }

        

        public virtual void speak(){
            Console.WriteLine("Hello, my name is " + name + " and I am the " + status + " in this restaurant! ");
        }
    }
}
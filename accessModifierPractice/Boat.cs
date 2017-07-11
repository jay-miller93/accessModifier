using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessModifierPractice
{
    class Boat
    {
        //so far we have done all fields as private but we can do them as public
        public int numOfPass;

        //most of the time tho we want our fields to be private
        private string name;
        private string engineSize;

        //properties almost always have public as their access modifier
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //constructors always have a public access modifier
        public Boat()
        {
            //this is my default constructor

        }
        //methods
        public void Move()
        {
            //code to make boate move
        }
        private double CalculateMPG()
        {
            double MPG = 20.0;
            //code to calculate MPG
            return MPG;
        }
    }
}

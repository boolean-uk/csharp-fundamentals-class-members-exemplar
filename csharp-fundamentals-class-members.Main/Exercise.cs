using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_fundamentals_class_members_exemplar.Main
{
    public class Exercise
    {
        // Below is an example of a class member in c#.
        // Where a class describes a thing, a member describes its attributes.
        // If Car were a class, some members of it might be colour, transmission, make and model.
        // The structure of defining a member is <visibility> <data type> <name> = <value>
        // The below member has a visibility of public, meaning other classes can see and change the value.
        // It has data type of int, which stands for integer. A numeric value.
        // Its name can be anything as long as that name isn't already in use.
        public int answerToTheUltimateQuestion = 42;


        //TODO: 1. Create an integer member named age with a value of 32
        public int age = 33;



        //TODO: 2. Create a String member named firstName with a value of "Jane"       
        public string firstName
        {
            get { return "Jane"; }           
        }


        //TODO: 3. Create a boolean member named isProgrammer with a value of true
        public bool isProgrammer
        {
            get { return true; }    
        }



        //TODO: 4. Change the value below so that the tests pass. Check the README.md file for instructions on
        // running and reading tests
        public int firstNumber = 109;



        //TODO: 5. Change the value below so that the tests pass
        public string firstString = "Ruby is to Python what car is to carpet.";



        //TODO: 6. Change the visibility below so that the tests pass
        public bool isVisible = true;

        
    }
}

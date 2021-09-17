using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        // adding ability to play with pet. use petname.play() in program.cs to call function
        public void play()
        {
            //play increase hunger by 10
            this.Hunger += 10;
            //play decrease boredom by 20
            this.Boredom -= 20;
            //play increase health by 10
            this.Health += 10;
        }
        // adding ability to feed the pet. use petname.play() in program.cs to call funcion
        public void feed()
        {
            //feed decrease hunger by 40
            this.Hunger -= 40;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCarLog
{
    class car
    {
        string make;
        string model;
        string registration;
        string body;
        string owner;
        string fuel;

        public car(string make, string model, string registration, string body, string owner, string fuel)
        {


            this.make = make;
            this.model = model;
            this.registration = registration;
            this.body = body;
            this.owner = owner;
            this.fuel = fuel;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Registration { get => registration; set => registration = value; }
        public string Body { get => body; set => body = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Fuel { get => fuel; set => fuel = value; }
    }
}

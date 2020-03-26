using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Intro
{
    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }
        }
        public bool Peeled { get; private set; }

        public string Peel()
        {
            Peeled = true;
            return "You peel the banana.";
        }
        public string Slice()
        {
            return "You have small bananas now";
        }

        public Banana() { }
        public Banana(bool isPeeled)
        {
            Peeled = isPeeled;
        }
    }

    public class Orange : IFruit
    {
        public string Name
        {
            get { return "Orange"; }
        }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the orange";
        }
        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out!";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }
        public bool Peeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}

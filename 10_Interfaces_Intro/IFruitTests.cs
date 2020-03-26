using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_Intro
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            var output = banana.Peel();
            Console.WriteLine(output);
            Console.WriteLine("The banana is peeled: " + banana.Peeled);
            Assert.IsTrue(banana.Peeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            var orange = new Orange();
            
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange
            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }
            Console.WriteLine(orange.Squeeze());
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("This fruit is called Grape"));
           
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var tomato = new Grape();
            var fruitSalad = new List<IFruit>
            {
                new Orange(),
                new Grape(),
                new Banana(true),
                new Orange(),
                new Banana(),
                tomato,
            };
            Console.WriteLine("Is the banana peeled?");
            foreach(var fruit in fruitSalad)
            {
                if(fruit is Banana)
                {
                    var banana = (Banana)fruit;
                    if (banana.Peeled)
                    {
                        Console.WriteLine("Yes the banana is peeled!");
                        banana.Slice();
                    }
                    else
                    {
                        Console.WriteLine("Sorry bud, this banana isn't peeled");
                    }
                }
                else if(fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Congrats on the Grape");
                }
                else
                {
                    Console.WriteLine("What a nice orange you have...too bad its not a tangerine :(");
                }
            }
        }
    }
}

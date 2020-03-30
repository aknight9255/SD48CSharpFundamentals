using System;
using System.Collections.Generic;
using _11_StreamingContent_UIRefactor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _11_StreamingContent_UIRefactorTests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutPutShouldContainList()
        {
            //Arrange 
            List<string> commandList = new List<string> { "1", "5" };
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);

            //ACT
            program.Run();
            Console.WriteLine(console.Output);

            //ASSERT 
            Assert.IsTrue(console.Output.Contains("Princess Bride"));
        }
        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            //Arrange 
            var commandList = new List<string> { "3", "This is a test", "22", "4", "false", "1234,01,24", "1","5" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);
            //ACT
            ui.Run();
            Console.WriteLine(console.Output);
            Assert.IsTrue(console.Output.Contains("This is a test"));
        }

        [TestMethod]
        public void RemoveFromList_ShouldSeeRemovedMessage()
        {
            var commandList = new List<string> { "4","2","5"};
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            ui.Run();
            Console.WriteLine(console.Output);

            Assert.IsTrue(console.Output.Contains("Jack has been removed"));
        }
    }
}

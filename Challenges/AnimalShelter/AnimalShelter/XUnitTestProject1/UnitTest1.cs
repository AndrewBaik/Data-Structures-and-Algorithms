using System;
using Xunit;
using AnimalShelter;
using AnimalShelter.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestingEnqueue()
        {
            Queue testingAnimalShelter = new Queue(new AnimalsShelter("dog"));
            testingAnimalShelter.Enqueue(new AnimalsShelter("cat"));

            //string answer = testingAnimalShelter.Front.Next.Value;
            Assert.Equal("cat", testingAnimalShelter.Front.Next.Value);
        }
       
        [Fact]
        public void TestingDequeue()
        {
            Queue testingAnimalShelter2 = new Queue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("cat"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("dog"));

           // string answer = testingAnimalShelter2.Front.Next.Value;
            Assert.Equal("dog", testingAnimalShelter2.Front.Next.Value);
        }
    }
}

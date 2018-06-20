using System;
using Xunit;
using AnimalShelter;
using AnimalShelter.Classes;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestingEnqueue()
        {
            Queue testingAnimalShelter = new Queue(new AnimalsShelter("dog"));
            testingAnimalShelter.Enqueue(new AnimalsShelter("cat"));
            testingAnimalShelter.Enqueue(new AnimalsShelter("cat"));
            testingAnimalShelter.Enqueue(new AnimalsShelter("dog"));

            Assert.Equal("cat", testingAnimalShelter.Front.Next.Value);
            Assert.Equal("cat", testingAnimalShelter.Front.Next.Next.Value);
            Assert.Equal("dog", testingAnimalShelter.Front.Next.Next.Next.Value);
        }

        [Fact]
        public void TestingDequeue()
        {
            Queue testingAnimalShelter2 = new Queue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("cat"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("cat"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("cat"));
            testingAnimalShelter2.Enqueue(new AnimalsShelter("dog"));
            testingAnimalShelter2.Dequeue("cat");

            Assert.Equal("dog", testingAnimalShelter2.Front.Next.Value);
            Assert.Equal("cat", testingAnimalShelter2.Front.Next.Next.Value);
            Assert.Equal("dog", testingAnimalShelter2.Front.Next.Next.Next.Value);
        }
    }
}

using RepeatedWord;
using System;
using Xunit;
using RepeatedWord.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestTheAnswerForFirstExample()
        {
            string question1 = "Once upon a time, there was a brave princess who";

            Assert.Equal("a", Program.Repeated_Word(question1));
        }

        [Fact]
        public void TestTheAnswerForSecondExample()
        {
            string question2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only";

            Assert.Equal( "was", Program.Repeated_Word(question2));
        }

        [Fact]
        public void TestTheAnswerForThirdExample()
        {
            string question3 = "A room without books is like a body without a soul";

            Assert.Equal("without", Program.Repeated_Word(question3));
        }

        [Fact]
        public void TestTheAnswerForNoRepeatedWord()
        {
            string noRepeat1 = "So many books, so little time.";
            string noRepeat2 = "In three words I can sum up everything I've learned about life: it goes on.";
            string noRepeat3 = "No one can make you feel inferior without your consent";

            Assert.Equal("No Repeated word found", Program.Repeated_Word(noRepeat1));
            Assert.Equal("No Repeated word found", Program.Repeated_Word(noRepeat2));
            Assert.Equal("No Repeated word found", Program.Repeated_Word(noRepeat3));
        }
    }
}

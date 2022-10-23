namespace JP
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Basic_Test_Of_The_Number_1()
        {
            string s = "c#", a = "c#";
            Assert.AreEqual(a, JomoPipi.jumbledString(s, 0));
        }
        [Test]
        public void Basic_Test_Of_The_Number_2()
        {
            string s = "Such Wow!", a = "Sc o!uhWw";
            Assert.AreEqual(a, JomoPipi.jumbledString(s, 1));
        }
        [Test]
        public void Basic_Test_Of_The_Number_3()
        {
            string s = "better example", a = "bexltept merae";
            Assert.AreEqual(a, JomoPipi.jumbledString(s, 2));
        }
        [Test]
        public void Basic_Test_Of_The_Number_4()
        {
            string s = "qwertyuio", a = "qtorieuwy";
            Assert.AreEqual(a, JomoPipi.jumbledString(s, 2));
        }
        [Test]
        public void Basic_Test_Of_The_Number_5()
        {
            string s = "Greetings", a = "Gtsegenri";
            Assert.AreEqual(a, JomoPipi.jumbledString(s, 8));
        }
    }
}
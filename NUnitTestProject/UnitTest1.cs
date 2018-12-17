using NUnit.Framework;

using ConsoleAppUnitTestsLab7;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void EmailValidate_someMail_true()
        {
            // Arrange.

            string email = @"someEmail@gmail.com";
            bool expected = true;

            // Act.
            bool actual = Validator.EmailValidate(email);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EmailValidate_someMail_false()
        {
            // Arrange.

            string email = @"someEwda@@@ma4545il@gmail.c232om";
            bool expected = false;

            // Act.
            bool actual = Validator.EmailValidate(email);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PhoneNumberValidate_380555555555_true()
        {
            // Arrange.

            string phoneNumber = "380555555555";
            bool expected = true;

            // Act.
            bool actual = Validator.PhoneNumberValidate(phoneNumber);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PhoneNumberValidate_i4u35u34ui55_false()
        {
            // Arrange.

            string phoneNumber = "i4u35u34ui55";
            bool expected = false;

            // Act.
            bool actual = Validator.PhoneNumberValidate(phoneNumber);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

    }
}
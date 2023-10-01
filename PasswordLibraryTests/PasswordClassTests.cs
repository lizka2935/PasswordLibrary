using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordLibrary;

namespace PasswordLibraryTests
{
    [TestClass]
    public class PasswordClassTests
    {
        [TestMethod]
        public void CheckPassword_EmptyString_ReturnedException()
        {
            //Arrange
            string password = "";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPasswordSmallString_ReturnedException()
        {
            //Arrange
            string password = "1dK$";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPassword_BigString_ReturnedException()
        {
            //Arrange
            string password = "sdfsdkfjsdkfsdfkJhfjsdhfjdd%dfs1";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual =()=> obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPassword_SmallLetters_ReturnedException()
        {
            //Arrange
            string password = "smallletters";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPassword_BigLetters_ReturnedException()
        {
            //Arrange
            string password = "BIGLETTERS";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        [TestMethod]
        public void CheckPassword_Numbers_ReturnedException()
        {
            //Arrange
            string password = "123123221312";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPassword_Symbols_ReturnedException()
        {
            //Arrange
            string password = "!@#$%^&*";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        [TestMethod]
        public void CheckPassword_LettersSymbols_ReturnedException()
        {
            //Arrange
            string password = "dsfJFkdk@#";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPassword_LettersNumbers_ReturnedException()
        {
            //Arrange
            string password = "sdjfKFJD4823";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void CheckPassword_NumbersSymbols_ReturnedException()
        {
            //Arrange
            string password = "12312213##@";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        [TestMethod]
        public void CheckPassword_Password_ReturnedException()
        {
            //Arrange
            string password = "Passwordd123@";

            //Act
            PasswordClass obj = new PasswordClass();
            bool actual = obj.CheckPassword(password);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void CheckPassword_Cyrillic_ReturnedException()
        {
            //Arrange
            string password = "PassworddЯ123@";

            //Act
            PasswordClass obj = new PasswordClass();
            Action actual = () => obj.CheckPassword(password);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        
    }
}

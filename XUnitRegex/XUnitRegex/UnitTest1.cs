using System;
using Xunit;

namespace XUnitRegex
{
    /// <summary>
    /// class created
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// Firstnameisnulls this instance.
        /// </summary>
        [Fact]
        public void firstnameisnull()
        {
            //firstname is passed true
            Assert.True(Userregistration.FirstName("Rajat"));
        }

        /// <summary>
        /// Test2s this instance.
        /// </summary>
        [Fact]
        public void firstname()
        {
            Assert.False(Userregistration.FirstName(" "));
        }
        [Fact]
        public void lastnameisnull()
        {
            //lastname is passed true
            Assert.True(Userregistration.LastName("Ravindra"));
        }
        //last name is passed false
        [Fact]
        public void lastname()
        {
            Assert.False(Userregistration.LastName(" "));
        }
        //email is passed
        [Fact]
        public void emailisnull()
        {
            //email is passed true
            Assert.True(Userregistration.email("rajatravindar504@gmail.com"));
        }
        //email is passed false
        [Fact]
        public void email()
        {
            Assert.False(Userregistration.email(" "));
        }
        [Fact]
        //password is true
        public void passwordisnull()
        {
            Assert.True(Userregistration.password("Qwerty@123678"));
        }
        //password is passed false
        [Fact]
        public void password()
        {
            Assert.False(Userregistration.password(" "));
        }
        [Fact]
        //contact is true
        public void contactisnull()
        {
            Assert.True(Userregistration.contact("8210431386"));
        }
        //contact is false
        [Fact]
        public void contact()
        {
            Assert.False(Userregistration.contact(" "));
        }
    }
    
}
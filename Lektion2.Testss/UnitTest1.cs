using System;
using Xunit;
using Lektion2;

namespace Lektion2.Tests
{
    public class UnitTest1
    {
        #region ** Kronor Class Tast Region **


        #region Testing the IsPositive method in Kronor
        [Fact]
        public void IsPositive_TrueTest()
        {
            
            Kronor expected = new Kronor(10,0);

            Assert.True(expected.IsPositive());
            Assert.False(expected.isZero());
            Assert.False(expected.isNegative());
        }
        #endregion

        #region Testing the IsNegative method in Kronor
        [Fact]
        public void IsNegative_TrueTest()
        {
            Kronor kronor = new Kronor(-10,0);

            Assert.True(kronor.isNegative());
            Assert.False(kronor.isZero());
            Assert.False(kronor.IsPositive());
        }
        #endregion

        #region Testing the IsZero method in Kronor
        [Fact]
        public void IsZero_TrueTest()
        {

            Kronor kronor = new Kronor();

            Kronor kronor2 = new Kronor(0,0);


            Assert.True(kronor.isZero());
            Assert.False(kronor.isNegative());
            Assert.False(kronor.IsPositive());

            Assert.True(kronor2.isZero());
            Assert.False(kronor2.isNegative());
            Assert.False(kronor2.IsPositive());
        }
        #endregion

        #region Testing the CopyConstructor Kronor(Kronor kronor) in Kronor
        [Fact]
        public void CopyKronor_Test()
        {
            Kronor act1 = new Kronor(10,50);
            Kronor expected = new Kronor(act1);

            Assert.Equal(expected.KronorPart(), act1.KronorPart());
            Assert.Equal(expected.ÖrenPart(),act1.ÖrenPart());
        }
        #endregion

        #region Testing the KronorPart method in Kronor
        [Fact]
        public void KroorPart_Test ()
        {
            Kronor act1 = new Kronor(10, 0);
            int expected = 10;

            Assert.Equal(expected, act1.KronorPart());
        }

        #endregion

        #region Testing ÖrePart method in Kronor
        [Fact]
        public void ÖrePart_Test()
        {
            Kronor act1 = new Kronor(0, 10);
            int expected = 10;

            Assert.Equal(expected, act1.ÖrenPart());
        }
        #endregion

        #region Testing the Add method in Kronor
        [Fact]
        public void AddToKronor_Test()
        {
            var addObj = new Kronor(10,100);
            var baseObj = new Kronor(10,100);
            //var add2Obj = new Kronor(50,200); ---> fel check
            
            var expected = new Kronor(20,200);

            Assert.Equal(expected.Öre, baseObj.Add(addObj).Öre);
            Assert.Equal(expected.ÖrenPart(), baseObj.Add(addObj).ÖrenPart());
            Assert.Equal(expected.KronorPart(), baseObj.Add(addObj).KronorPart());
            
            //Assert.Equal(expected.Öre, act2.Add(add2Obj).Öre); ---> fel check
        }

        #endregion

        #region Testing the Subtract method in Kronor
        [Fact]
        public void SubtractFromKronor_Test()
        {
            var subObj = new Kronor(10, 100);
            var baseObj = new Kronor(30, 300);
            
            var expected = new Kronor(20, 200);

            Assert.Equal(expected.Öre, baseObj.Subtract(subObj).Öre);
            Assert.Equal(expected.ÖrenPart(), baseObj.Subtract(subObj).ÖrenPart());
            Assert.Equal(expected.KronorPart(), baseObj.Subtract(subObj).KronorPart());
        }
        #endregion
        #endregion

        #region ** Wallet Class Test Region **

        #region Testing Wallet constructor with Kronor money param
        [Fact]
        public void WalletConstructor_Test()
        {
            var act1 = new Kronor(10, 20);
            var act2 = new Wallet(act1);
            
            var expected = new Kronor(10, 20);

            Assert.Equal(expected.Öre, act2.Amount.Öre);
            Assert.Equal(expected.KronorPart(), act2.Amount.KronorPart());
            Assert.Equal(expected.ÖrenPart(), act2.Amount.ÖrenPart());
        }
        #endregion

        #region Testing Add method in Wallet
        [Fact]
        public void WalletAdd_Test()
        {
            var act1 = new Kronor(123, 10);
            var act2 = new Kronor(10,10);
            var baseObj = new Wallet(act1);
            baseObj.Add(act2);

            var expected = new Kronor(133, 20);

            Assert.Equal(expected.Öre, baseObj.Amount.Öre);
            Assert.Equal(expected.ÖrenPart(), baseObj.Amount.ÖrenPart());
            Assert.Equal(expected.KronorPart(), baseObj.Amount.KronorPart());
            
        }
        #endregion

        #endregion

        [Fact]
        public void Test_IsPositive_True()
        {
            var kronor = new Kronor(10, 0);

            var result = kronor.IsPositive();

            Assert.True(result);
        }
        
        [Fact]
        public void Test_IsPositive_False()
        {
            var kronor = new Kronor(-10, 0);

            var result = kronor.IsPositive();

            Assert.False(result);
        }

        [Fact]
        public void CreateAccountAndAddMoney_Test()
        {
            var act1 = new Account(new Kronor(10,20));

            Assert.Equal(10, act1.Amount.KronorPart());
            Assert.Equal(20, act1.Amount.ÖrenPart());
            Assert.Equal(1020, act1.Amount.Öre);

        }

        [Fact]
        public void AddingNullToAccount_test()
        {
            var act1 = new Account();

            Assert.Null(act1.Amount);
        }

    }
}
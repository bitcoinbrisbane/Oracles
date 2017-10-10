using System;
using Xunit;
using Nethereum.Web3;
using System.Numerics;
using Nethereum.Util;
using System.IO;
using System.Text;

namespace coretests
{
    public class UnitTests : Helper
    {
        public UnitTests()
        {
            Object[] constructorParms = new Object[0];
            DeplyContract(contractPath, contractName, constructorParms);
        }

        [Fact]
        public void Should_Get_New_Price()
        {
            var contract = GetContract(contractName);
            var functionToTest = contract.GetFunction("newPrice");

            var actual = functionToTest.CallAsync<UInt64>().Result;
            Assert.Equal(0, actual);
        }

        public void Should_Add_New_Price()
        {
            var contract = GetContract(contractName);
            var functionToTest = contract.GetFunction("newPrice");

            Nethereum.Hex.HexTypes.HexBigInteger gas = new Nethereum.Hex.HexTypes.HexBigInteger(2000000);
            BigInteger ethToSend = Nethereum.Util.UnitConversion.Convert.ToWei(amount, Nethereum.Util.UnitConversion.EthUnit.Ether);
            Nethereum.Hex.HexTypes.HexBigInteger eth = new Nethereum.Hex.HexTypes.HexBigInteger(ethToSend); 

            Object[] functionParams = new Object[0];
            var tx = functionToTest.SendTransactionAsync(owner, gas, eth, functionParams).Result;

            Assert.NotNull(tx);
        }
    }
}

pragma solidity ^0.4.2;

import "truffle/Assert.sol";
import "truffle/DeployedAddresses.sol";
import "../contracts/AUDOracle.sol";

contract TestAUDOracle {

  function testInitialBalanceUsingDeployedContract() {
    AUDOracle oracle = AUDOracle(DeployedAddresses.AUDOracle());

    uint expected = 0;

    Assert.equal(oracle.value(), expected, "Should be zero on deploy");
  }
}

var Oracle = artifacts.require("../contracts/AUDOracle.sol");

module.exports = function(deployer) {
  // deployer.deploy(ConvertLib);
  // deployer.link(ConvertLib, MetaCoin);
  deployer.deploy(AUDOracle);
};

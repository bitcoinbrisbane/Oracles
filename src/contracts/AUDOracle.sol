pragma solidity ^0.4.13;

contract AUDOracle {
	uint public value;
	address owner;

	function AUDOracle() {
		owner = msg.sender;
	}

	function newPrice(uint256 _value) {
		require(msg.sender == owner);
		value = value;
		Updated(value);
	}

	event Updated(uint256 _value);
}
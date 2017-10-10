# Oracles
Repo for the Ethereum Brisbane October 2017 meetup

Oracles are often spoken about in the case of ethereum smart contracts, but poorly understood.  Likewise, there are some misconceptions or misunderstanding on how ETH contracts can interface with the "outside world"

This meetup we will take a look at what they are and how to use them. Ill use the brave new coin offerings and look at other services like oracalize.

On the night, I will build our own oracle on a public testnet for others to consume.

• Arrive around 6 for Pizza, beers and mingling
• Ill kick off the talk around 6:30pm
• Aim to finish at 7:30pm
• Hit the Platform bar around 8pm for the usual conversations.

Ill stream the event live on the Blockchain Australia’s YouTube channel.

## Agenda

Develop a smart contract in Visual Studio Code
Use truffle to deploy to testrpc
Create a python script to call the node / smart contract, using the price feed from https://api.cryptowat.ch/markets/quoine/ethaud/price
    pip install 'jsonrpcclient[requests]'
    pip install ethjsonrpc
Create a dot net core app to call the node / smart contract using Nethereum
    dotnet new xunit
    dotnet add package Nethereum.Portable --version 2.0.1
    dotnet restore
    

## Notes
Contract owner 0xe2356d29d5dfecb4ee43c031204aeded24749959.  scripts.sh will start a test rpc node.
```
testrpc --account="0x221bbb8b9b508c2841a60f862e9d03c19997f99ee83db94e077ff180265247,100000000000000000000"
```
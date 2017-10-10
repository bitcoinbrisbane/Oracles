## Note, requires pip install json-rpc
## pip install 'jsonrpcclient[requests]'
## pip install ethjsonrpc

import requests
import json
import jsonrpcclient

## https://api.cryptowat.ch/markets/quoine/ethaud/price
print('')
print('Call api')
r = requests.get('https://api.cryptowat.ch/markets/quoine/ethaud/price')
print r.json()

data = r.json()

result = data['result']
price = result['price']

print('')
print('ETH AUD price is')
print price

node_url = '127.0.0.1' # Test RPC
contract_address = '0x8db2caae9ef066aedf81423b9ae0e92a2603c533' # Testrpc

from ethjsonrpc import EthJsonRpc
c = EthJsonRpc(node_url, 8545)

# Test connect
blockHeight = c.eth_blockNumber()
print('')
print(blockHeight)

contract_owner = '210f1e4c56d68f63ab4bf41157bbca253abfec45' # Test rpc
date = time.localtime()

tx = c.call_with_transaction(contract_owner, contract_address, 'addClick(uint256)', [date])

print()
print(tx)
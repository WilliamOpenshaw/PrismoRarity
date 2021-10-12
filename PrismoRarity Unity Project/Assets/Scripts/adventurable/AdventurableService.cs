using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Scripts.Contracts.adventurable.ContractDefinition;

namespace Scripts.Contracts.adventurable
{
    public partial class AdventurableService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, AdventurableDeployment adventurableDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<AdventurableDeployment>().SendRequestAndWaitForReceiptAsync(adventurableDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, AdventurableDeployment adventurableDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<AdventurableDeployment>().SendRequestAsync(adventurableDeployment);
        }

        public static async Task<AdventurableService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, AdventurableDeployment adventurableDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, adventurableDeployment, cancellationTokenSource);
            return new AdventurableService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public AdventurableService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AdventureRequestAsync(AdventureFunction adventureFunction)
        {
             return ContractHandler.SendRequestAsync(adventureFunction);
        }

        public Task<TransactionReceipt> AdventureRequestAndWaitForReceiptAsync(AdventureFunction adventureFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(adventureFunction, cancellationToken);
        }

        public Task<string> AdventureRequestAsync(BigInteger summoner)
        {
            var adventureFunction = new AdventureFunction();
                adventureFunction.Summoner = summoner;
            
             return ContractHandler.SendRequestAsync(adventureFunction);
        }

        public Task<TransactionReceipt> AdventureRequestAndWaitForReceiptAsync(BigInteger summoner, CancellationTokenSource cancellationToken = null)
        {
            var adventureFunction = new AdventureFunction();
                adventureFunction.Summoner = summoner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(adventureFunction, cancellationToken);
        }

        public Task<BigInteger> Adventurers_logQueryAsync(Adventurers_logFunction adventurers_logFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Adventurers_logFunction, BigInteger>(adventurers_logFunction, blockParameter);
        }

        
        public Task<BigInteger> Adventurers_logQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var adventurers_logFunction = new Adventurers_logFunction();
                adventurers_logFunction.Summoner = summoner;
            
            return ContractHandler.QueryAsync<Adventurers_logFunction, BigInteger>(adventurers_logFunction, blockParameter);
        }
    }
}

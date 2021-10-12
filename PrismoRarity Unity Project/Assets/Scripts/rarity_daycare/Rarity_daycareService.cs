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
using Scripts.Contracts.rarity_daycare.ContractDefinition;

namespace Scripts.Contracts.rarity_daycare
{
    public partial class Rarity_daycareService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Rarity_daycareDeployment rarity_daycareDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_daycareDeployment>().SendRequestAndWaitForReceiptAsync(rarity_daycareDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Rarity_daycareDeployment rarity_daycareDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_daycareDeployment>().SendRequestAsync(rarity_daycareDeployment);
        }

        public static async Task<Rarity_daycareService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Rarity_daycareDeployment rarity_daycareDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, rarity_daycareDeployment, cancellationTokenSource);
            return new Rarity_daycareService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Rarity_daycareService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> DaysPaidQueryAsync(DaysPaidFunction daysPaidFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DaysPaidFunction, BigInteger>(daysPaidFunction, blockParameter);
        }

        
        public Task<BigInteger> DaysPaidQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var daysPaidFunction = new DaysPaidFunction();
                daysPaidFunction.Summoner = summoner;
            
            return ContractHandler.QueryAsync<DaysPaidFunction, BigInteger>(daysPaidFunction, blockParameter);
        }
    }
}

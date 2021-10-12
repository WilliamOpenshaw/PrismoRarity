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
using Scripts.Contracts.rarity_mat1.ContractDefinition;

namespace Scripts.Contracts.rarity_mat1
{
    public partial class Rarity_mat1Service
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Rarity_mat1Deployment rarity_mat1Deployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_mat1Deployment>().SendRequestAndWaitForReceiptAsync(rarity_mat1Deployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Rarity_mat1Deployment rarity_mat1Deployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_mat1Deployment>().SendRequestAsync(rarity_mat1Deployment);
        }

        public static async Task<Rarity_mat1Service> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Rarity_mat1Deployment rarity_mat1Deployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, rarity_mat1Deployment, cancellationTokenSource);
            return new Rarity_mat1Service(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Rarity_mat1Service(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
        }

        
        public Task<BigInteger> AllowanceQueryAsync(BigInteger owner, BigInteger spender, BlockParameter blockParameter = null)
        {
            var allowanceFunction = new AllowanceFunction();
                allowanceFunction.Owner = owner;
                allowanceFunction.Spender = spender;
            
            return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
        }

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<string> ApproveRequestAsync(BigInteger from, BigInteger spender, BigInteger amount)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.From = from;
                approveFunction.Spender = spender;
                approveFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(BigInteger from, BigInteger spender, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.From = from;
                approveFunction.Spender = spender;
                approveFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfQueryAsync(BigInteger owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DecimalsFunction, byte>(decimalsFunction, blockParameter);
        }

        
        public Task<byte> DecimalsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DecimalsFunction, byte>(null, blockParameter);
        }

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> ScoutQueryAsync(ScoutFunction scoutFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ScoutFunction, BigInteger>(scoutFunction, blockParameter);
        }

        
        public Task<BigInteger> ScoutQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var scoutFunction = new ScoutFunction();
                scoutFunction.Summoner = summoner;
            
            return ContractHandler.QueryAsync<ScoutFunction, BigInteger>(scoutFunction, blockParameter);
        }

        public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        
        public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        
        public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> TransferRequestAsync(TransferFunction transferFunction)
        {
             return ContractHandler.SendRequestAsync(transferFunction);
        }

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public Task<string> TransferRequestAsync(BigInteger from, BigInteger to, BigInteger amount)
        {
            var transferFunction = new TransferFunction();
                transferFunction.From = from;
                transferFunction.To = to;
                transferFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(transferFunction);
        }

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(BigInteger from, BigInteger to, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var transferFunction = new TransferFunction();
                transferFunction.From = from;
                transferFunction.To = to;
                transferFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(BigInteger executor, BigInteger from, BigInteger to, BigInteger amount)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.Executor = executor;
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(BigInteger executor, BigInteger from, BigInteger to, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.Executor = executor;
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }
    }
}

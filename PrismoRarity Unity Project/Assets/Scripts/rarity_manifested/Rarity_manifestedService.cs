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
using Scripts.Contracts.rarity_manifested.ContractDefinition;

namespace Scripts.Contracts.rarity_manifested
{
    public partial class Rarity_manifestedService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Rarity_manifestedDeployment rarity_manifestedDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_manifestedDeployment>().SendRequestAndWaitForReceiptAsync(rarity_manifestedDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Rarity_manifestedDeployment rarity_manifestedDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_manifestedDeployment>().SendRequestAsync(rarity_manifestedDeployment);
        }

        public static async Task<Rarity_manifestedService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Rarity_manifestedDeployment rarity_manifestedDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, rarity_manifestedDeployment, cancellationTokenSource);
            return new Rarity_manifestedService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Rarity_manifestedService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public Task<BigInteger> ClassQueryAsync(ClassFunction @classFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ClassFunction, BigInteger>(@classFunction, blockParameter);
        }

        
        public Task<BigInteger> ClassQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var @classFunction = new ClassFunction();
                @classFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ClassFunction, BigInteger>(@classFunction, blockParameter);
        }

        public Task<string> ClassesQueryAsync(ClassesFunction classesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ClassesFunction, string>(classesFunction, blockParameter);
        }

        
        public Task<string> ClassesQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var classesFunction = new ClassesFunction();
                classesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ClassesFunction, string>(classesFunction, blockParameter);
        }

        public Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        
        public Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getApprovedFunction = new GetApprovedFunction();
                getApprovedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        
        public Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null)
        {
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Owner = owner;
                isApprovedForAllFunction.Operator = @operator;
            
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public Task<BigInteger> LevelQueryAsync(LevelFunction levelFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LevelFunction, BigInteger>(levelFunction, blockParameter);
        }

        
        public Task<BigInteger> LevelQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var levelFunction = new LevelFunction();
                levelFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<LevelFunction, BigInteger>(levelFunction, blockParameter);
        }

        public Task<string> Level_upRequestAsync(Level_upFunction level_upFunction)
        {
             return ContractHandler.SendRequestAsync(level_upFunction);
        }

        public Task<TransactionReceipt> Level_upRequestAndWaitForReceiptAsync(Level_upFunction level_upFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(level_upFunction, cancellationToken);
        }

        public Task<string> Level_upRequestAsync(BigInteger summoner)
        {
            var level_upFunction = new Level_upFunction();
                level_upFunction.Summoner = summoner;
            
             return ContractHandler.SendRequestAsync(level_upFunction);
        }

        public Task<TransactionReceipt> Level_upRequestAndWaitForReceiptAsync(BigInteger summoner, CancellationTokenSource cancellationToken = null)
        {
            var level_upFunction = new Level_upFunction();
                level_upFunction.Summoner = summoner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(level_upFunction, cancellationToken);
        }

        public Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        
        public Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFrom1Function safeTransferFrom1Function)
        {
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction)
        {
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved, CancellationTokenSource cancellationToken = null)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public Task<SummonerOutputDTO> SummonerQueryAsync(SummonerFunction summonerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<SummonerFunction, SummonerOutputDTO>(summonerFunction, blockParameter);
        }

        public Task<SummonerOutputDTO> SummonerQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var summonerFunction = new SummonerFunction();
                summonerFunction.Summoner = summoner;
            
            return ContractHandler.QueryDeserializingToObjectAsync<SummonerFunction, SummonerOutputDTO>(summonerFunction, blockParameter);
        }

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }
    }
}

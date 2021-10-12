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
using Scripts.Contracts.rarity_skills.ContractDefinition;

namespace Scripts.Contracts.rarity_skills
{
    public partial class Rarity_skillsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Rarity_skillsDeployment rarity_skillsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_skillsDeployment>().SendRequestAndWaitForReceiptAsync(rarity_skillsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Rarity_skillsDeployment rarity_skillsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_skillsDeployment>().SendRequestAsync(rarity_skillsDeployment);
        }

        public static async Task<Rarity_skillsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Rarity_skillsDeployment rarity_skillsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, rarity_skillsDeployment, cancellationTokenSource);
            return new Rarity_skillsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Rarity_skillsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> Calculate_points_for_setQueryAsync(Calculate_points_for_setFunction calculate_points_for_setFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Calculate_points_for_setFunction, BigInteger>(calculate_points_for_setFunction, blockParameter);
        }

        
        public Task<BigInteger> Calculate_points_for_setQueryAsync(BigInteger @class, List<byte> skills, BlockParameter blockParameter = null)
        {
            var calculate_points_for_setFunction = new Calculate_points_for_setFunction();
                calculate_points_for_setFunction.Class = @class;
                calculate_points_for_setFunction.Skills = skills;
            
            return ContractHandler.QueryAsync<Calculate_points_for_setFunction, BigInteger>(calculate_points_for_setFunction, blockParameter);
        }

        public Task<List<bool>> Class_skillsQueryAsync(Class_skillsFunction class_skillsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Class_skillsFunction, List<bool>>(class_skillsFunction, blockParameter);
        }

        
        public Task<List<bool>> Class_skillsQueryAsync(BigInteger @class, BlockParameter blockParameter = null)
        {
            var class_skillsFunction = new Class_skillsFunction();
                class_skillsFunction.Class = @class;
            
            return ContractHandler.QueryAsync<Class_skillsFunction, List<bool>>(class_skillsFunction, blockParameter);
        }

        public Task<List<byte>> Get_skillsQueryAsync(Get_skillsFunction get_skillsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Get_skillsFunction, List<byte>>(get_skillsFunction, blockParameter);
        }

        
        public Task<List<byte>> Get_skillsQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var get_skillsFunction = new Get_skillsFunction();
                get_skillsFunction.Summoner = summoner;
            
            return ContractHandler.QueryAsync<Get_skillsFunction, List<byte>>(get_skillsFunction, blockParameter);
        }

        public Task<BigInteger> Skills_per_levelQueryAsync(Skills_per_levelFunction skills_per_levelFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Skills_per_levelFunction, BigInteger>(skills_per_levelFunction, blockParameter);
        }

        
        public Task<BigInteger> Skills_per_levelQueryAsync(BigInteger @int, BigInteger @class, BigInteger level, BlockParameter blockParameter = null)
        {
            var skills_per_levelFunction = new Skills_per_levelFunction();
                skills_per_levelFunction.Int = @int;
                skills_per_levelFunction.Class = @class;
                skills_per_levelFunction.Level = level;
            
            return ContractHandler.QueryAsync<Skills_per_levelFunction, BigInteger>(skills_per_levelFunction, blockParameter);
        }
    }
}

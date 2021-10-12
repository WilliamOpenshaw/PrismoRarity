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
using Scripts.Contracts.rarity_attributes.ContractDefinition;

namespace Scripts.Contracts.rarity_attributes
{
    public partial class Rarity_attributesService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Rarity_attributesDeployment rarity_attributesDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_attributesDeployment>().SendRequestAndWaitForReceiptAsync(rarity_attributesDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Rarity_attributesDeployment rarity_attributesDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_attributesDeployment>().SendRequestAsync(rarity_attributesDeployment);
        }

        public static async Task<Rarity_attributesService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Rarity_attributesDeployment rarity_attributesDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, rarity_attributesDeployment, cancellationTokenSource);
            return new Rarity_attributesService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Rarity_attributesService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> Abilities_by_levelQueryAsync(Abilities_by_levelFunction abilities_by_levelFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Abilities_by_levelFunction, BigInteger>(abilities_by_levelFunction, blockParameter);
        }

        
        public Task<BigInteger> Abilities_by_levelQueryAsync(BigInteger level, BlockParameter blockParameter = null)
        {
            var abilities_by_levelFunction = new Abilities_by_levelFunction();
                abilities_by_levelFunction.Level = level;
            
            return ContractHandler.QueryAsync<Abilities_by_levelFunction, BigInteger>(abilities_by_levelFunction, blockParameter);
        }

        public Task<Ability_scoresOutputDTO> Ability_scoresQueryAsync(Ability_scoresFunction ability_scoresFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_scoresFunction, Ability_scoresOutputDTO>(ability_scoresFunction, blockParameter);
        }

        public Task<Ability_scoresOutputDTO> Ability_scoresQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var ability_scoresFunction = new Ability_scoresFunction();
                ability_scoresFunction.Summoner = summoner;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_scoresFunction, Ability_scoresOutputDTO>(ability_scoresFunction, blockParameter);
        }

        public Task<bool> Character_createdQueryAsync(Character_createdFunction character_createdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Character_createdFunction, bool>(character_createdFunction, blockParameter);
        }

        
        public Task<bool> Character_createdQueryAsync(BigInteger summoner, BlockParameter blockParameter = null)
        {
            var character_createdFunction = new Character_createdFunction();
                character_createdFunction.Summoner = summoner;
            
            return ContractHandler.QueryAsync<Character_createdFunction, bool>(character_createdFunction, blockParameter);
        }
    }
}

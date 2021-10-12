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
using Scripts.Contracts.rarity_lib.ContractDefinition;

namespace Scripts.Contracts.rarity_lib
{
    public partial class Rarity_libService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Rarity_libDeployment rarity_libDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_libDeployment>().SendRequestAndWaitForReceiptAsync(rarity_libDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Rarity_libDeployment rarity_libDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Rarity_libDeployment>().SendRequestAsync(rarity_libDeployment);
        }

        public static async Task<Rarity_libService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Rarity_libDeployment rarity_libDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, rarity_libDeployment, cancellationTokenSource);
            return new Rarity_libService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Rarity_libService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<Ability_modifiersOutputDTO> Ability_modifiersQueryAsync(Ability_modifiersFunction ability_modifiersFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_modifiersFunction, Ability_modifiersOutputDTO>(ability_modifiersFunction, blockParameter);
        }

        public Task<Ability_modifiersOutputDTO> Ability_modifiersQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var ability_modifiersFunction = new Ability_modifiersFunction();
                ability_modifiersFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_modifiersFunction, Ability_modifiersOutputDTO>(ability_modifiersFunction, blockParameter);
        }

        public Task<Ability_scoresOutputDTO> Ability_scoresQueryAsync(Ability_scoresFunction ability_scoresFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_scoresFunction, Ability_scoresOutputDTO>(ability_scoresFunction, blockParameter);
        }

        public Task<Ability_scoresOutputDTO> Ability_scoresQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var ability_scoresFunction = new Ability_scoresFunction();
                ability_scoresFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_scoresFunction, Ability_scoresOutputDTO>(ability_scoresFunction, blockParameter);
        }

        public Task<Ability_scores_fullOutputDTO> Ability_scores_fullQueryAsync(Ability_scores_fullFunction ability_scores_fullFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_scores_fullFunction, Ability_scores_fullOutputDTO>(ability_scores_fullFunction, blockParameter);
        }

        public Task<Ability_scores_fullOutputDTO> Ability_scores_fullQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var ability_scores_fullFunction = new Ability_scores_fullFunction();
                ability_scores_fullFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Ability_scores_fullFunction, Ability_scores_fullOutputDTO>(ability_scores_fullFunction, blockParameter);
        }

        public Task<BaseOutputDTO> BaseQueryAsync(BaseFunction @baseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<BaseFunction, BaseOutputDTO>(@baseFunction, blockParameter);
        }

        public Task<BaseOutputDTO> BaseQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var @baseFunction = new BaseFunction();
                @baseFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<BaseFunction, BaseOutputDTO>(@baseFunction, blockParameter);
        }

        public Task<string> DescriptionQueryAsync(DescriptionFunction descriptionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DescriptionFunction, string>(descriptionFunction, blockParameter);
        }

        
        public Task<string> DescriptionQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var descriptionFunction = new DescriptionFunction();
                descriptionFunction.S = s;
            
            return ContractHandler.QueryAsync<DescriptionFunction, string>(descriptionFunction, blockParameter);
        }

        public Task<GoldOutputDTO> GoldQueryAsync(GoldFunction goldFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GoldFunction, GoldOutputDTO>(goldFunction, blockParameter);
        }

        public Task<GoldOutputDTO> GoldQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var goldFunction = new GoldFunction();
                goldFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GoldFunction, GoldOutputDTO>(goldFunction, blockParameter);
        }

        public Task<Items1OutputDTO> Items1QueryAsync(Items1Function items1Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Items1Function, Items1OutputDTO>(items1Function, blockParameter);
        }

        public Task<Items1OutputDTO> Items1QueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var items1Function = new Items1Function();
                items1Function.Owner = owner;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Items1Function, Items1OutputDTO>(items1Function, blockParameter);
        }

        public Task<MaterialsOutputDTO> MaterialsQueryAsync(MaterialsFunction materialsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<MaterialsFunction, MaterialsOutputDTO>(materialsFunction, blockParameter);
        }

        public Task<MaterialsOutputDTO> MaterialsQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var materialsFunction = new MaterialsFunction();
                materialsFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<MaterialsFunction, MaterialsOutputDTO>(materialsFunction, blockParameter);
        }

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public Task<string> NameQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var nameFunction = new NameFunction();
                nameFunction.S = s;
            
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public Task<SkillsOutputDTO> SkillsQueryAsync(SkillsFunction skillsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<SkillsFunction, SkillsOutputDTO>(skillsFunction, blockParameter);
        }

        public Task<SkillsOutputDTO> SkillsQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var skillsFunction = new SkillsFunction();
                skillsFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<SkillsFunction, SkillsOutputDTO>(skillsFunction, blockParameter);
        }

        public Task<Summoner_fullOutputDTO> Summoner_fullQueryAsync(Summoner_fullFunction summoner_fullFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Summoner_fullFunction, Summoner_fullOutputDTO>(summoner_fullFunction, blockParameter);
        }

        public Task<Summoner_fullOutputDTO> Summoner_fullQueryAsync(BigInteger s, BlockParameter blockParameter = null)
        {
            var summoner_fullFunction = new Summoner_fullFunction();
                summoner_fullFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Summoner_fullFunction, Summoner_fullOutputDTO>(summoner_fullFunction, blockParameter);
        }

        public Task<Summoners_fullOutputDTO> Summoners_fullQueryAsync(Summoners_fullFunction summoners_fullFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<Summoners_fullFunction, Summoners_fullOutputDTO>(summoners_fullFunction, blockParameter);
        }

        public Task<Summoners_fullOutputDTO> Summoners_fullQueryAsync(List<BigInteger> s, BlockParameter blockParameter = null)
        {
            var summoners_fullFunction = new Summoners_fullFunction();
                summoners_fullFunction.S = s;
            
            return ContractHandler.QueryDeserializingToObjectAsync<Summoners_fullFunction, Summoners_fullOutputDTO>(summoners_fullFunction, blockParameter);
        }
    }
}

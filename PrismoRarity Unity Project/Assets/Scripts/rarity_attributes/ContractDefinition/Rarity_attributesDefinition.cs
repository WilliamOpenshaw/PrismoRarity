using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Scripts.Contracts.rarity_attributes.ContractDefinition
{


    public partial class Rarity_attributesDeployment : Rarity_attributesDeploymentBase
    {
        public Rarity_attributesDeployment() : base(BYTECODE) { }
        public Rarity_attributesDeployment(string byteCode) : base(byteCode) { }
    }

    public class Rarity_attributesDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public Rarity_attributesDeploymentBase() : base(BYTECODE) { }
        public Rarity_attributesDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class Abilities_by_levelFunction : Abilities_by_levelFunctionBase { }

    [Function("abilities_by_level", "uint256")]
    public class Abilities_by_levelFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_level", 1)]
        public virtual BigInteger Level { get; set; }
    }

    public partial class Ability_scoresFunction : Ability_scoresFunctionBase { }

    [Function("ability_scores", typeof(Ability_scoresOutputDTO))]
    public class Ability_scoresFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_summoner", 1)]
        public virtual BigInteger Summoner { get; set; }
    }

    public partial class Character_createdFunction : Character_createdFunctionBase { }

    [Function("character_created", "bool")]
    public class Character_createdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_summoner", 1)]
        public virtual BigInteger Summoner { get; set; }
    }

    public partial class Abilities_by_levelOutputDTO : Abilities_by_levelOutputDTOBase { }

    [FunctionOutput]
    public class Abilities_by_levelOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Ability_scoresOutputDTO : Ability_scoresOutputDTOBase { }

    [FunctionOutput]
    public class Ability_scoresOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
        [Parameter("uint32", "", 2)]
        public virtual uint ReturnValue2 { get; set; }
        [Parameter("uint32", "", 3)]
        public virtual uint ReturnValue3 { get; set; }
        [Parameter("uint32", "", 4)]
        public virtual uint ReturnValue4 { get; set; }
        [Parameter("uint32", "", 5)]
        public virtual uint ReturnValue5 { get; set; }
        [Parameter("uint32", "", 6)]
        public virtual uint ReturnValue6 { get; set; }
    }

    public partial class Character_createdOutputDTO : Character_createdOutputDTOBase { }

    [FunctionOutput]
    public class Character_createdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}

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

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{


    public partial class Rarity_libDeployment : Rarity_libDeploymentBase
    {
        public Rarity_libDeployment() : base(BYTECODE) { }
        public Rarity_libDeployment(string byteCode) : base(byteCode) { }
    }

    public class Rarity_libDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public Rarity_libDeploymentBase() : base(BYTECODE) { }
        public Rarity_libDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class Ability_modifiersFunction : Ability_modifiersFunctionBase { }

    [Function("ability_modifiers", typeof(Ability_modifiersOutputDTO))]
    public class Ability_modifiersFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class Ability_scoresFunction : Ability_scoresFunctionBase { }

    [Function("ability_scores", typeof(Ability_scoresOutputDTO))]
    public class Ability_scoresFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class Ability_scores_fullFunction : Ability_scores_fullFunctionBase { }

    [Function("ability_scores_full", typeof(Ability_scores_fullOutputDTO))]
    public class Ability_scores_fullFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class BaseFunction : BaseFunctionBase { }

    [Function("base", typeof(BaseOutputDTO))]
    public class BaseFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class DescriptionFunction : DescriptionFunctionBase { }

    [Function("description", "string")]
    public class DescriptionFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class GoldFunction : GoldFunctionBase { }

    [Function("gold", typeof(GoldOutputDTO))]
    public class GoldFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class Items1Function : Items1FunctionBase { }

    [Function("items1", typeof(Items1OutputDTO))]
    public class Items1FunctionBase : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class MaterialsFunction : MaterialsFunctionBase { }

    [Function("materials", typeof(MaterialsOutputDTO))]
    public class MaterialsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class SkillsFunction : SkillsFunctionBase { }

    [Function("skills", typeof(SkillsOutputDTO))]
    public class SkillsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class Summoner_fullFunction : Summoner_fullFunctionBase { }

    [Function("summoner_full", typeof(Summoner_fullOutputDTO))]
    public class Summoner_fullFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_s", 1)]
        public virtual BigInteger S { get; set; }
    }

    public partial class Summoners_fullFunction : Summoners_fullFunctionBase { }

    [Function("summoners_full", typeof(Summoners_fullOutputDTO))]
    public class Summoners_fullFunctionBase : FunctionMessage
    {
        [Parameter("uint256[]", "_s", 1)]
        public virtual List<BigInteger> S { get; set; }
    }

    public partial class Ability_modifiersOutputDTO : Ability_modifiersOutputDTOBase { }

    [FunctionOutput]
    public class Ability_modifiersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Ability_modifiers ReturnValue1 { get; set; }
    }

    public partial class Ability_scoresOutputDTO : Ability_scoresOutputDTOBase { }

    [FunctionOutput]
    public class Ability_scoresOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Ability_scores ReturnValue1 { get; set; }
    }

    public partial class Ability_scores_fullOutputDTO : Ability_scores_fullOutputDTOBase { }

    [FunctionOutput]
    public class Ability_scores_fullOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Ability_scores_full ReturnValue1 { get; set; }
    }

    public partial class BaseOutputDTO : BaseOutputDTOBase { }

    [FunctionOutput]
    public class BaseOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Base ReturnValue1 { get; set; }
    }

    public partial class DescriptionOutputDTO : DescriptionOutputDTOBase { }

    [FunctionOutput]
    public class DescriptionOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GoldOutputDTO : GoldOutputDTOBase { }

    [FunctionOutput]
    public class GoldOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Gold ReturnValue1 { get; set; }
    }

    public partial class Items1OutputDTO : Items1OutputDTOBase { }

    [FunctionOutput]
    public class Items1OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<Item1> ReturnValue1 { get; set; }
    }

    public partial class MaterialsOutputDTO : MaterialsOutputDTOBase { }

    [FunctionOutput]
    public class MaterialsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<Material> ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SkillsOutputDTO : SkillsOutputDTOBase { }

    [FunctionOutput]
    public class SkillsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Skills ReturnValue1 { get; set; }
    }

    public partial class Summoner_fullOutputDTO : Summoner_fullOutputDTOBase { }

    [FunctionOutput]
    public class Summoner_fullOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Summoner ReturnValue1 { get; set; }
    }

    public partial class Summoners_fullOutputDTO : Summoners_fullOutputDTOBase { }

    [FunctionOutput]
    public class Summoners_fullOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<Summoner> ReturnValue1 { get; set; }
    }
}

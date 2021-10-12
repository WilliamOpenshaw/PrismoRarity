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

namespace Scripts.Contracts.rarity_skills.ContractDefinition
{


    public partial class Rarity_skillsDeployment : Rarity_skillsDeploymentBase
    {
        public Rarity_skillsDeployment() : base(BYTECODE) { }
        public Rarity_skillsDeployment(string byteCode) : base(byteCode) { }
    }

    public class Rarity_skillsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public Rarity_skillsDeploymentBase() : base(BYTECODE) { }
        public Rarity_skillsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class Calculate_points_for_setFunction : Calculate_points_for_setFunctionBase { }

    [Function("calculate_points_for_set", "uint256")]
    public class Calculate_points_for_setFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_class", 1)]
        public virtual BigInteger Class { get; set; }
        [Parameter("uint8[36]", "_skills", 2)]
        public virtual List<byte> Skills { get; set; }
    }

    public partial class Class_skillsFunction : Class_skillsFunctionBase { }

    [Function("class_skills", "bool[36]")]
    public class Class_skillsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_class", 1)]
        public virtual BigInteger Class { get; set; }
    }

    public partial class Get_skillsFunction : Get_skillsFunctionBase { }

    [Function("get_skills", "uint8[36]")]
    public class Get_skillsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_summoner", 1)]
        public virtual BigInteger Summoner { get; set; }
    }

    public partial class Skills_per_levelFunction : Skills_per_levelFunctionBase { }

    [Function("skills_per_level", "uint256")]
    public class Skills_per_levelFunctionBase : FunctionMessage
    {
        [Parameter("int256", "_int", 1)]
        public virtual BigInteger Int { get; set; }
        [Parameter("uint256", "_class", 2)]
        public virtual BigInteger Class { get; set; }
        [Parameter("uint256", "_level", 3)]
        public virtual BigInteger Level { get; set; }
    }

    public partial class Calculate_points_for_setOutputDTO : Calculate_points_for_setOutputDTOBase { }

    [FunctionOutput]
    public class Calculate_points_for_setOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "points", 1)]
        public virtual BigInteger Points { get; set; }
    }

    public partial class Class_skillsOutputDTO : Class_skillsOutputDTOBase { }

    [FunctionOutput]
    public class Class_skillsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool[36]", "_skills", 1)]
        public virtual List<bool> Skills { get; set; }
    }

    public partial class Get_skillsOutputDTO : Get_skillsOutputDTOBase { }

    [FunctionOutput]
    public class Get_skillsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8[36]", "", 1)]
        public virtual List<byte> ReturnValue1 { get; set; }
    }

    public partial class Skills_per_levelOutputDTO : Skills_per_levelOutputDTOBase { }

    [FunctionOutput]
    public class Skills_per_levelOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "points", 1)]
        public virtual BigInteger Points { get; set; }
    }
}

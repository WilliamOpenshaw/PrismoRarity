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

namespace Scripts.Contracts.adventurable.ContractDefinition
{


    public partial class AdventurableDeployment : AdventurableDeploymentBase
    {
        public AdventurableDeployment() : base(BYTECODE) { }
        public AdventurableDeployment(string byteCode) : base(byteCode) { }
    }

    public class AdventurableDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public AdventurableDeploymentBase() : base(BYTECODE) { }
        public AdventurableDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AdventureFunction : AdventureFunctionBase { }

    [Function("adventure")]
    public class AdventureFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_summoner", 1)]
        public virtual BigInteger Summoner { get; set; }
    }

    public partial class Adventurers_logFunction : Adventurers_logFunctionBase { }

    [Function("adventurers_log", "uint256")]
    public class Adventurers_logFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_summoner", 1)]
        public virtual BigInteger Summoner { get; set; }
    }



    public partial class Adventurers_logOutputDTO : Adventurers_logOutputDTOBase { }

    [FunctionOutput]
    public class Adventurers_logOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }
}

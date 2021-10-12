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

namespace Scripts.Contracts.rarity_daycare.ContractDefinition
{


    public partial class Rarity_daycareDeployment : Rarity_daycareDeploymentBase
    {
        public Rarity_daycareDeployment() : base(BYTECODE) { }
        public Rarity_daycareDeployment(string byteCode) : base(byteCode) { }
    }

    public class Rarity_daycareDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public Rarity_daycareDeploymentBase() : base(BYTECODE) { }
        public Rarity_daycareDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DaysPaidFunction : DaysPaidFunctionBase { }

    [Function("daysPaid", "uint256")]
    public class DaysPaidFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_summoner", 1)]
        public virtual BigInteger Summoner { get; set; }
    }

    public partial class DaysPaidOutputDTO : DaysPaidOutputDTOBase { }

    [FunctionOutput]
    public class DaysPaidOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "days_paid", 1)]
        public virtual BigInteger Days_paid { get; set; }
    }
}

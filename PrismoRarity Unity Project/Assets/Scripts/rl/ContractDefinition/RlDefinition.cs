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

namespace Scripts.Contracts.rl.ContractDefinition
{


    public partial class RlDeployment : RlDeploymentBase
    {
        public RlDeployment() : base(BYTECODE) { }
        public RlDeployment(string byteCode) : base(byteCode) { }
    }

    public class RlDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566037600b82828239805160001a607314602a57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea26469706673582212206f40d5e3e7aba1d1dda968d2afb267e788f23c0297539f597922e4e201aeace864736f6c63430008090033";
        public RlDeploymentBase() : base(BYTECODE) { }
        public RlDeploymentBase(string byteCode) : base(byteCode) { }

    }
}

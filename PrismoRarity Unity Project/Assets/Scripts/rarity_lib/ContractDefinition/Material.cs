using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Material : MaterialBase { }

    public class MaterialBase 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
        [Parameter("uint256", "scout", 2)]
        public virtual BigInteger Scout { get; set; }
        [Parameter("uint256", "log", 3)]
        public virtual BigInteger Log { get; set; }
    }
}

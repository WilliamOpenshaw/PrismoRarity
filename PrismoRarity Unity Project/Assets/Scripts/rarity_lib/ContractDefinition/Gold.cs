using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Gold : GoldBase { }

    public class GoldBase 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
        [Parameter("uint256", "claimed", 2)]
        public virtual BigInteger Claimed { get; set; }
        [Parameter("uint256", "claimable", 3)]
        public virtual BigInteger Claimable { get; set; }
    }
}

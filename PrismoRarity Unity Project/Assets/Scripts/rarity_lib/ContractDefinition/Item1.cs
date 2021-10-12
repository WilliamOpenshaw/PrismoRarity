using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Item1 : Item1Base { }

    public class Item1Base 
    {
        [Parameter("uint256", "token_id", 1)]
        public virtual BigInteger Token_id { get; set; }
        [Parameter("uint8", "base_type", 2)]
        public virtual byte Base_type { get; set; }
        [Parameter("uint8", "item_type", 3)]
        public virtual byte Item_type { get; set; }
        [Parameter("uint32", "crafted", 4)]
        public virtual uint Crafted { get; set; }
        [Parameter("uint256", "crafter", 5)]
        public virtual BigInteger Crafter { get; set; }
    }
}

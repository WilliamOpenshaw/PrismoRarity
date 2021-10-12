using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Base : BaseBase { }

    public class BaseBase 
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("uint256", "xp", 2)]
        public virtual BigInteger Xp { get; set; }
        [Parameter("uint256", "log", 3)]
        public virtual BigInteger Log { get; set; }
        [Parameter("uint256", "class", 4)]
        public virtual BigInteger Class { get; set; }
        [Parameter("uint256", "level", 5)]
        public virtual BigInteger Level { get; set; }
    }
}

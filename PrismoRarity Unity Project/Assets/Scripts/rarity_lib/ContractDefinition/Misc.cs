using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Misc : MiscBase { }

    public class MiscBase 
    {
        [Parameter("uint256", "daycare_days_paid", 1)]
        public virtual BigInteger Daycare_days_paid { get; set; }
    }
}

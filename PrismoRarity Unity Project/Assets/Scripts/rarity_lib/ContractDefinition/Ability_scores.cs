using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Ability_scores : Ability_scoresBase { }

    public class Ability_scoresBase 
    {
        [Parameter("uint32", "_str", 1)]
        public virtual uint Str { get; set; }
        [Parameter("uint32", "_dex", 2)]
        public virtual uint Dex { get; set; }
        [Parameter("uint32", "_con", 3)]
        public virtual uint Con { get; set; }
        [Parameter("uint32", "_int", 4)]
        public virtual uint Int { get; set; }
        [Parameter("uint32", "_wis", 5)]
        public virtual uint Wis { get; set; }
        [Parameter("uint32", "_cha", 6)]
        public virtual uint Cha { get; set; }
    }
}

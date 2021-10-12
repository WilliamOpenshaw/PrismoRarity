using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Ability_modifiers : Ability_modifiersBase { }

    public class Ability_modifiersBase 
    {
        [Parameter("int32", "_str", 1)]
        public virtual int Str { get; set; }
        [Parameter("int32", "_dex", 2)]
        public virtual int Dex { get; set; }
        [Parameter("int32", "_con", 3)]
        public virtual int Con { get; set; }
        [Parameter("int32", "_int", 4)]
        public virtual int Int { get; set; }
        [Parameter("int32", "_wis", 5)]
        public virtual int Wis { get; set; }
        [Parameter("int32", "_cha", 6)]
        public virtual int Cha { get; set; }
    }
}

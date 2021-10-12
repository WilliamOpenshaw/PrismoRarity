using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Summoner : SummonerBase { }

    public class SummonerBase 
    {
        [Parameter("tuple", "base", 1)]
        public virtual Base Base { get; set; }
        [Parameter("tuple", "ability_scores", 2)]
        public virtual Ability_scores_full Ability_scores { get; set; }
        [Parameter("tuple", "skills", 3)]
        public virtual Skills Skills { get; set; }
        [Parameter("tuple", "gold", 4)]
        public virtual Gold Gold { get; set; }
        [Parameter("tuple[]", "materials", 5)]
        public virtual List<Material> Materials { get; set; }
        [Parameter("tuple", "misc", 6)]
        public virtual Misc Misc { get; set; }
    }
}

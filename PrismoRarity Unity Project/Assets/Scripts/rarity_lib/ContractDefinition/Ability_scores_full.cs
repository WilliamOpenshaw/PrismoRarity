using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Ability_scores_full : Ability_scores_fullBase { }

    public class Ability_scores_fullBase 
    {
        [Parameter("tuple", "attributes", 1)]
        public virtual Ability_scores Attributes { get; set; }
        [Parameter("tuple", "modifiers", 2)]
        public virtual Ability_modifiers Modifiers { get; set; }
        [Parameter("uint256", "total_points", 3)]
        public virtual BigInteger Total_points { get; set; }
        [Parameter("uint256", "spent_points", 4)]
        public virtual BigInteger Spent_points { get; set; }
        [Parameter("bool", "created", 5)]
        public virtual bool Created { get; set; }
    }
}

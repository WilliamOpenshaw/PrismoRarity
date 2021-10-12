using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Scripts.Contracts.rarity_lib.ContractDefinition
{
    public partial class Skills : SkillsBase { }

    public class SkillsBase 
    {
        [Parameter("uint8[36]", "skills", 1)]
        public virtual List<byte> Skills { get; set; }
        [Parameter("bool[36]", "class_skills", 2)]
        public virtual List<bool> Class_skills { get; set; }
        [Parameter("uint256", "total_points", 3)]
        public virtual BigInteger Total_points { get; set; }
        [Parameter("uint256", "spent_points", 4)]
        public virtual BigInteger Spent_points { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RagnarokItensPriceTool
{

    public class ItemData
    {
        public ItemDataHeader Header { get; set; }
        public List<ItemDB> Body { get; set; }
    }

    public class ItemDataHeader
    { 
        public string Type { get; set; }
        public int Version { get; set; }
    }

    public class ItemDB
    {
        public int Id { get; set; }
        public string? AegisName { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? SubType { get; set; }
        public int? Buy { get; set; }
        public int? Sell { get; set; }
        public int? Weight { get; set; }

        public int? Attack { get; set; } // Optional
        public int? MagicAttack { get; set; } // Optional
        public int? Defense { get; set; } // Optional
        public int? Range { get; set; } // Optional
        public int? Slots { get; set; } // Optional
        public Dictionary<string, bool>? Jobs { get; set; } // Optional
        public Dictionary<string, bool>? Classes { get; set; } // Optional
        public string? Gender { get; set; } // Optional
        public Dictionary<string, bool>? Locations { get; set; } // Optional
        public int? WeaponLevel { get; set; } // Optional
        public int? ArmorLevel { get; set; } // Optional
        public int? EquipLevelMin { get; set; } // Optional
        public int? EquipLevelMax { get; set; } // Optional
        public bool? Refineable { get; set; } // Optional
        public int? View { get; set; } // Optional
        public string? AliasName { get; set; } // Optional
        public Flag? Flags { get; set; } // Optional
        public DelayInfo? Delay { get; set; } // Optional
        public StackInfo? Stack { get; set; } // Optional
        public NoUseConditions? NoUse { get; set; } // Optional
        public TradeRestrictions? Trade { get; set; } // Optional
        public string? Script { get; set; } // Optional
        public string? EquipScript { get; set; } // Optional
        public string? UnEquipScript { get; set; } // Optional
    }

    public class Flag
    {
        public bool? BindOnEquip { get; set; }
        public bool? BuyingStore { get; set; }
        public bool? Container { get; set; }
        public bool? DeadBranch { get; set; }
        public bool? DropAnnounce { get; set; }
        public string? DropEffect { get; set; }
        public bool? NoConsume { get; set; }
        public bool? UniqueId { get; set; }

    }

    // Additional classes for complex fields
    public class DelayInfo
    {
        public int? Duration { get; set; } // Optional
        public string? Status { get; set; } // Optional
    }

    public class StackInfo
    {
        public int? Amount { get; set; } // Optional
        public bool? Inventory { get; set; } // Optional
        public bool? Cart { get; set; } // Optional
        public bool? Storage { get; set; } // Optional
        public bool? GuildStorage { get; set; } // Optional
    }

    public class NoUseConditions
    {
        public int? Override { get; set; } // Optional
        public bool? Sitting { get; set; } // Optional
    }

    public class TradeRestrictions
    {
        public int? Override { get; set; } // Optional
        public bool? NoDrop { get; set; } // Optional
        public bool? NoTrade { get; set; } // Optional
        public bool? TradePartner { get; set; } // Optional
        public bool? NoSell { get; set; } // Optional
        public bool? NoCart { get; set; } // Optional
        public bool? NoStorage { get; set; } // Optional
        public bool? NoGuildStorage { get; set; } // Optional
        public bool? NoMail { get; set; } // Optional
        public bool? NoAuction { get; set; } // Optional
    }
}

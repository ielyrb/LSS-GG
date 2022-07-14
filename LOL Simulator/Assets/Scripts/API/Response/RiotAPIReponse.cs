using System.Collections.Generic;
<<<<<<< HEAD

//public class Abilities
//{
//    public List<P> P { get; set; }
//    public List<Q> Q { get; set; }
//    public List<W> W { get; set; }
//    public List<E> E { get; set; }
//    public List<R> R { get; set; }
//}
=======
public class ChampData
{
    public string type { get; set; }
    public string format { get; set; }
    public string version { get; set; }
    public Data data { get; set; }
}
>>>>>>> a2e113094b5f3dfa8b497b0f75f5f5f58c5e6fa1

public class Champion
{
    public string id { get; set; }
    public string key { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public Image image { get; set; }
    public List<Skin> skins { get; set; }
    public string lore { get; set; }
    public string blurb { get; set; }
    public List<string> allytips { get; set; }
    public List<string> enemytips { get; set; }
    public List<string> tags { get; set; }
    public string partype { get; set; }
    public Info info { get; set; }
    public Stats stats { get; set; }
    public List<Spell> spells { get; set; }
    public Passive passive { get; set; }
    public List<object> recommended { get; set; }
}

public class ChampionsRe
{
    public string _id { get; set; }
    public ChampData champData { get; set; }
}

public class Data
{
    public Champion Champion { get; set; }
}

public class Datavalues
{
}

public class Image
{
    public string full { get; set; }
    public string sprite { get; set; }
    public string group { get; set; }
    public double x { get; set; }
    public double y { get; set; }
    public double w { get; set; }
    public double h { get; set; }
}

public class Info
{
    public double attack { get; set; }
    public double defense { get; set; }
    public double magic { get; set; }
    public double difficulty { get; set; }
}

public class Leveltip
{
    public List<string> label { get; set; }
    public List<string> effect { get; set; }
}

public class Passive
{
    public string name { get; set; }
    public string description { get; set; }
<<<<<<< HEAD
    public string region { get; set; }
}

public class Effect
{
    public string description { get; set; }
    public List<Leveling> leveling { get; set; }
}

public class GameplayRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Health
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class HealthRegen
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Leveling
{
    public string attribute { get; set; }
    public List<Modifier> modifiers { get; set; }
}

public class MagicResistance
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Mana
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class ManaRegen
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Modifier
{
    public List<double> values { get; set; }
    public List<string> units { get; set; }
}

public class Movespeed
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class PathingRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Price
{
    public int blueEssence { get; set; }
    public int rp { get; set; }
    public int saleRp { get; set; }
}

public class Abilities
{
    public string name { get; set; }
    public string icon { get; set; }
    public List<Effect> effects { get; set; }
    public Cost cost { get; set; }
    public Cooldown cooldown { get; set; }
    public string targeting { get; set; }
    public string affects { get; set; }
    public string spellshieldable { get; set; }
    public string resource { get; set; }
    public string damageType { get; set; }
    public string spellEffects { get; set; }
    public string projectile { get; set; }
    public object onHitEffects { get; set; }
    public string occurrence { get; set; }
    public string notes { get; set; }
    public string blurb { get; set; }
    public object missileSpeed { get; set; }
    public object rechargeRate { get; set; }
    public object collisionRadius { get; set; }
    public object tetherRadius { get; set; }
    public object onTargetCdStatic { get; set; }
    public object innerRadius { get; set; }
    public object speed { get; set; }
    public object width { get; set; }
    public object angle { get; set; }
    public string castTime { get; set; }
    public object effectRadius { get; set; }
    public object targetRange { get; set; }
}

public class Rarity
{
    public int? rarity { get; set; }
    public string region { get; set; }
=======
    public Image image { get; set; }
>>>>>>> a2e113094b5f3dfa8b497b0f75f5f5f58c5e6fa1
}

public class RiotAPIResponse
{
<<<<<<< HEAD
    public int id { get; set; }
    public string key { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public string icon { get; set; }
    public string resource { get; set; }
    public string attackType { get; set; }
    public string adaptiveType { get; set; }
    public Stats stats { get; set; }
    public List<string> roles { get; set; }
    public AttributeRatings attributeRatings { get; set; }
    //public Abilities abilities { get; set; }
    public Dictionary<string, Abilities> abilities { get; set; }
    public string releaseDate { get; set; }
    public string releasePatch { get; set; }
    public string patchLastChanged { get; set; }
    public Price price { get; set; }
    public string lore { get; set; }
    public List<Skin> skins { get; set; }
}

public class SelectionRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
=======
    public List<ChampionsRe> ChampionsRes { get; set; }
>>>>>>> a2e113094b5f3dfa8b497b0f75f5f5f58c5e6fa1
}

public class Skin
{
    public string id { get; set; }
    public double num { get; set; }
    public string name { get; set; }
    public bool chromas { get; set; }
}

public class Spell
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string tooltip { get; set; }
    public Leveltip leveltip { get; set; }
    public double maxrank { get; set; }
    public List<double> cooldown { get; set; }
    public string cooldownBurn { get; set; }
    public List<double> cost { get; set; }
    public string costBurn { get; set; }
    public Datavalues datavalues { get; set; }
    public List<List<double>> effect { get; set; }
    public List<string> effectBurn { get; set; }
    public List<object> vars { get; set; }
    public string costType { get; set; }
    public string maxammo { get; set; }
    public List<double> range { get; set; }
    public string rangeBurn { get; set; }
    public Image image { get; set; }
    public string resource { get; set; }
}

public class Stats
{
<<<<<<< HEAD
    public Health health { get; set; }
    public HealthRegen healthRegen { get; set; }
    public Mana mana { get; set; }
    public ManaRegen manaRegen { get; set; }
    public Armor armor { get; set; }
    public MagicResistance magicResistance { get; set; }
    public AttackDamage attackDamage { get; set; }
    public Movespeed movespeed { get; set; }
    public AcquisitionRadius acquisitionRadius { get; set; }
    public SelectionRadius selectionRadius { get; set; }
    public PathingRadius pathingRadius { get; set; }
    public GameplayRadius gameplayRadius { get; set; }
    public CriticalStrikeDamage criticalStrikeDamage { get; set; }
    public CriticalStrikeDamageModifier criticalStrikeDamageModifier { get; set; }
    public AttackSpeed attackSpeed { get; set; }
    public AttackSpeedRatio attackSpeedRatio { get; set; }
    public AttackCastTime attackCastTime { get; set; }
    public AttackTotalTime attackTotalTime { get; set; }
    public AttackDelayOffset attackDelayOffset { get; set; }
    public AttackRange attackRange { get; set; }
    public AramDamageTaken aramDamageTaken { get; set; }
    public AramDamageDealt aramDamageDealt { get; set; }
    public AramHealing aramHealing { get; set; }
    public AramShielding aramShielding { get; set; }
    public UrfDamageTaken urfDamageTaken { get; set; }
    public UrfDamageDealt urfDamageDealt { get; set; }
    public UrfHealing urfHealing { get; set; }
    public UrfShielding urfShielding { get; set; }
}

public class UrfDamageDealt
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class UrfDamageTaken
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class UrfHealing
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class UrfShielding
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}
=======
    public double hp { get; set; }
    public double hpperlevel { get; set; }
    public double mp { get; set; }
    public double mpperlevel { get; set; }
    public double movespeed { get; set; }
    public double armor { get; set; }
    public double armorperlevel { get; set; }
    public double spellblock { get; set; }
    public double spellblockperlevel { get; set; }
    public double attackrange { get; set; }
    public double hpregen { get; set; }
    public double hpregenperlevel { get; set; }
    public double mpregen { get; set; }
    public double mpregenperlevel { get; set; }
    public double crit { get; set; }
    public double critperlevel { get; set; }
    public double attackdamage { get; set; }
    public double attackdamageperlevel { get; set; }
    public double attackspeedperlevel { get; set; }
    public double attackspeed { get; set; }
}

>>>>>>> a2e113094b5f3dfa8b497b0f75f5f5f58c5e6fa1

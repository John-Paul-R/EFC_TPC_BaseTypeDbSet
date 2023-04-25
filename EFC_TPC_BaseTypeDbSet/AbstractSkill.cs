namespace EFSampleApp;

public class SkillArchetype
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<AbstractSkill> Skills { get; set; } = null!;
}

public abstract class AbstractSkill
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long ArchetypeId { get; set; }
    public SkillArchetype Archetype { get; set; } = null!;
}

public class MartialSkill : AbstractSkill
{
    public bool HasStrike { get; set; }
}

public class MagicSkill : AbstractSkill
{
    public string RunicName { get; set; } = null!;
}

public class Player
{
    public long Id { get; set; }
    public ICollection<PlayerToSkill> Skills { get; set; } = null!;
}

public class PlayerToSkill
{
    public long Id { get; set; }

    public long PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public long SkillId { get; set; }
    public AbstractSkill Skill { get; set; } = null!;
}

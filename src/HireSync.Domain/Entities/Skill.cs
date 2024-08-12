using HireSync.Domain.Enums;

namespace HireSync.Domain.Entities;

public class Skill
{
  #region properties

  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public SkillLevelEnum SkillLevel { get; set; }

  #endregion properties

  #region relationships

  public ICollection<ApplicationSkill> ApplicantSkills { get; set; } = [];
  public ICollection<JobSkill> JobSkills { get; set; } = [];

  #endregion relationships
}

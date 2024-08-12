namespace HireSync.Domain.Entities;

public class JobSkill
{


  #region relationships
  public int JobId { get; set; }

  public Job? Job { get; set; }

  public int SkillId { get; set; }

  public Skill? Skills { get; set; }

  #endregion relationship

}

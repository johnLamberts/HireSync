using HireSync.Domain.Entities.IdentiyUsers;

namespace HireSync.Domain.Entities;

public class ApplicationSkill
{
  public int ApplicantId { get; set; }

  public Applicant? Applicant { get; set; }

  public int SkillId { get; set; }

  public Skill? Skill { get; set; }
}

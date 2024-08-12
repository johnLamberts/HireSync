namespace HireSync.Domain.Entities.IdentiyUsers;

public class Experience
{

  #region properties

  #endregion


  #region navigation properties


  public int ApplicantId { get; set; }
  public Applicant? Applicant { get; set; }

  #endregion
}

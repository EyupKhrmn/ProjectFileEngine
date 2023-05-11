namespace Project.Domain.Entities;

public class Malfunction
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    
    #region Relation

    public User User { get; set; }
    public Computer Computer { get; set; }
    public Company Company { get; set; }

    #endregion
}
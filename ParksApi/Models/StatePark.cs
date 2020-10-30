using System.Collections.Generic;

namespace ParksApi.Models
{
  public class StatePark
  {
    public StatePark()
    {
      this.States = new HashSet<State>();
    }
    public int StateParkId { get; set; }
    public string StateParkName { get; set; }
    public string StateParkDescription { get; set; }
    public string StateParkLocation { get; set; }
    public virtual ICollection<State> States { get; set; }
  }
}
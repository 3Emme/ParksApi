using System.Collections.Generic;

namespace ParksApi.Models
{
  public class State
  {
    public State()
    {
      this.StateJoins = new HashSet<StateJoin>();
    }
    public int StateId { get; set; }
    public string StateName { get; set; }
    public string StateDescription { get; set; }
    public virtual ICollection<StateJoin> StateJoins { get; set; }
  }
}
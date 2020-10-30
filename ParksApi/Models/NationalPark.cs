using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ParksApi.Models
{
  public class NationalPark
  {
    public NationalPark()
    {      
      this.States = new HashSet<StateJoin>();     
    }
    public int NationalParkId { get; set; }
    public string NationalParkName { get; set; }
    public string NationalParkLocation { get; set; }
    public virtual ICollection<StateJoin> States { get; set; }
  }
}
namespace ParksApi.Models
{
  public class StateJoin
  {
    public int StateJoinId { get; set; }
    public int? StateParkId { get; set; }
    public int? NationalParkId { get; set; }
    public int StateId { get; set; }
    public virtual StatePark StatePark { get; set; }
    public virtual NationalPark NationalPark { get; set; }
    public virtual State State { get; set; }
  }
}
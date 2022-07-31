using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    [Display(Name = "Stylist Name")]
    public string StylistName { get; set; }
    [Display(Name = "Stylist Specialty")]
    public string StylistSpecialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }


  }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAngular1.Models
{
    [Table("Board")]
    public class Board
    {
        public int Id { get; set; }
        public string Zimmernummer { get; set; }
        public string Zimmer { get; set; }
        public string Patient { get; set; }
        public string Jahrgang { get; set; }
        public string Vers { get; set; }
        public string Fb { get; set; }
        public string Rea { get; set; }
        public string Iso { get; set; }
        public string Cl { get; set; }
        public string Ca { get; set; }
        public string Mob { get; set; }
        public string Hot { get; set; }
        public string Kost { get; set; }
        public string Eintritt { get; set; }
        public string Austritt { get; set; }
        public string Op { get; set; }
        public string Termine { get; set; }
        public string Bp { get; set; }
        public string Fd { get; set; }
        public string Sd { get; set; }
        public string Ptergo { get; set; }
        public string Nextpatient { get; set; }

        [NotMapped]
        public int GroupSize { get; set; }
    }
}

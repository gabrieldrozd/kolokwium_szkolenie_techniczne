namespace kolokwium.Models
{
    public class WynikiRozgrywek
    {
        public virtual int Id { get; set; }
        public virtual Druzyna Druzyna1 { get; set; }
        public virtual Druzyna Druzyna2 { get; set; }
        public virtual string Wynik { get; set; }
        public virtual TypRozgrywek TypRozgrywek { get; set; }
    }
}
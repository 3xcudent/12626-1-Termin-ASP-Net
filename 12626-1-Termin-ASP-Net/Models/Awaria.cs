using System;

namespace Models._12626_1_Termin_ASP_Net
{
    public class Awaria
    {
        public Awaria() { }
        public Awaria(string miejsce, int nrurzadzenia, string opis, DateTime data, bool usuniete)
        {
            Miejsce = miejsce;
            NrUrzadzenia = nrurzadzenia;
            Opis = opis;
            Data = data;
            Usuniete = usuniete;
        }
        public int ID { get; set; }
        public string Miejsce { get; set; }
        public int NrUrzadzenia { get; set; }
        public string Opis { get; set; }
        public DateTime Data { get; set; }
        public bool Usuniete { get; set; }
    }
}

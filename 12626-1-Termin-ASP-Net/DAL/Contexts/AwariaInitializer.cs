using Models._12626_1_Termin_ASP_Net;
using System;
using System.Linq;

namespace _12626_1_Termin_ASP_Net.DAL.Contexts
{
    public class AwariaInitializer
    {
        public static void Initialize(AwariaContext context)
        {
            if (context.Awaria.Any()) { return; }
            else {
                var awaria = new Awaria[]
         {
             new Awaria("Zakopane", 1, "Uszkodzona Uszczelka", DateTime.Now, false)
         };
                foreach (Awaria a in awaria) {context.Awaria.Add(a); }
            };
            context.SaveChanges();
        }
    }
}

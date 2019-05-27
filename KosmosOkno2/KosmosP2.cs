using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    partial class Kosmos
    {
        partial void UsunDoatkoweSatelity()
        {
            List<CialoNiebieskie> doUsuniecia = new List<CialoNiebieskie>();

            foreach (CialoNiebieskie cialo in cialaNiebieskie)
            {
                if (cialo.GetType().Name == "Planeta" || cialo.GetType().Name == "Ksiezyc")
                {
                    if (((ISatelita)cialo).PodajCialoOkrazane() == null)
                    {
                        doUsuniecia.Add(cialo);
                    }
                }
            }
            foreach (CialoNiebieskie cialo in doUsuniecia)
            {
                cialaNiebieskie.Remove(cialo);
            }
        }
    }
}

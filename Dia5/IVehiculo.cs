using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia5
{
    public interface IVehiculo
    {
        void Conducir();
        bool Repostar(int amount);
    }
}

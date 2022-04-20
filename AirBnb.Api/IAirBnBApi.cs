using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.Api
{
    public interface IAirBnBApi
    {
        AirBnbReservationResponse MakeReservation(string userName);
    }
}

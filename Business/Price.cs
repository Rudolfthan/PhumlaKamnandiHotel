using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiHotel.Business
{
    internal class Price
    {
        public enum Season
        {
            LowSeason,
            MidSeason,
            HighSeason
        }
        Season season;



        public Price()
        {

        }
        public decimal TotalFee(DateTime checkin)
        {

            decimal price = 0;
            DateTime lowcheckin = new DateTime(2024, 12, 01);
            DateTime midcheckin = new DateTime(2024, 12, 08);
            DateTime Highcheckin = new DateTime(2024, 12, 16);

            if (checkin.Date < midcheckin.Date)
            {
                price = 550;

            }
            else if ((checkin.Date >= midcheckin.Date) && (checkin.Date < Highcheckin.Date))
            {
                price = 750;

            }
            else if (checkin.Date >= Highcheckin.Date)
            {
                price = 995;

            }
            return price;


        }
    }
}

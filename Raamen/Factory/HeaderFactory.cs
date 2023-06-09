using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class HeaderFactory
    {
        public static Header newHeader(int userId)
        {
            Header header = new Header
            {
                CustomerId = userId,
                StaffId = 0,
                Date = DateTime.Now
            };

            return header;
        }
    }
}
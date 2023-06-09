using Raamen.Factory;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class HeaderHandler
    {
        public static Header insertHeader(int userId)
        {
            Header header = HeaderFactory.newHeader(userId);
            return HeaderRepository.insertHeader(header);
        }
    }
}
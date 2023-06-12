using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{   
    public class ReportHandler
    {
        public static List<Header> GetAllTransactions()
        {
            return ReportRepository.GetAllTransactions();
        }

        public static List<Raman> GetAllRamen()
        {
            return ReportRepository.GetAllRamen();
        }
        
    }
}
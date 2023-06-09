using Raamen.Factory;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class DetailHandler
    {
        public static Detail insertDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = DetailFactory.newDetail(headerId, ramenId, quantity);
            return DetailRepository.insertDetail(detail);
        }
        public static List<Detail> getTransactionDetail(int trxID)
        {
            return DetailRepository.getTransactionDetail(trxID);
        }
    }
}
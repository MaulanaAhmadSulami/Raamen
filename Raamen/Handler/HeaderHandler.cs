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
        public static List<Header> getTransactionUser(int userId)
        {
            return HeaderRepository.getTransactionUser(userId);
        }
        public static List<Header> getTransactionAll() // this one report
        {
            return HeaderRepository.getTransactionAll();
        }
        public static List<Header> getTransactionUnhandled()
        {
            return HeaderRepository.getTransactionUnhandled();
        }
        public static List<Header> getTransactionHandled()
        {
            return HeaderRepository.getTransactionHandled();
        }
        public static string handleTransaction(int trxId, int staffId)
        {
            return HeaderRepository.handleTransaction(trxId, staffId);
        }
    }
}
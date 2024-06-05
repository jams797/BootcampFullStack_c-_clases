using Consola2.Helpers;
using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Repository
{
    class BuyHistoryRepository
    {

        public List<BuyHistoryModel> GetAllHistory()
        {
            return MethodsHelper.historyBuy;
        }
        public BuyHistoryModel? GetLastBuyHistory()
        {
            return MethodsHelper.historyBuy.LastOrDefault();
        }

        public void RegisterBuyHistory(int idProd, int idPerson, int countP)
        {
            BuyHistoryModel? lastHistory = GetLastBuyHistory();

            BuyHistoryModel historyReg = new BuyHistoryModel
            {
                id = lastHistory == null ? 1 : (lastHistory.id + 1),
                idPerson = idPerson,
                idProduct = idProd,
                countP = countP,
            };

            MethodsHelper.historyBuy.Add(historyReg);
        }

        public bool HaveHistoryByPerson(int idPerson)
        {
            BuyHistoryModel? historyModel = MethodsHelper.historyBuy.FirstOrDefault(x => x.idPerson == idPerson);

            return historyModel != null;
        }

        public bool HaveHistoryByProduct(int idProduct)
        {
            BuyHistoryModel? historyModel = MethodsHelper.historyBuy.FirstOrDefault(x => x.idProduct == idProduct);

            return historyModel != null;
        }
    }
}

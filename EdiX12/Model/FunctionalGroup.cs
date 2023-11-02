using EdiX12.Model.Segments.Headers;
using EdiX12.Model.Segments.Trailers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model
{
    public class FunctionalGroup<TransactionSetType>
    {
        private int GroupControlNumber;
        private GS GS = new GS();
        private List<TransactionSetType> Transactions = new List<TransactionSetType>();
        private GE GE = new GE();

        public FunctionalGroup(TransactionSetType transactionSet)
        {
            Transactions.Add(transactionSet);
        }

        public FunctionalGroup(IEnumerable<TransactionSetType> transactionSets)
        {
            foreach (TransactionSetType transactionSet in transactionSets)
            {
                Transactions.Add(transactionSet);
            }
            GS.
        }

        public void Add(TransactionSetType transactionSet)
        {
            Transactions.Add(transactionSet);
        }
    }
}

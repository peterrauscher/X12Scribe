using X12Scribe.Model.Segments.Headers;
using X12Scribe.Model.Segments.Trailers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Model.TransactionSets;

namespace X12Scribe.Model.FunctionalGroups
{
    public class FunctionalGroup : IX12Object<TransactionSet>
    {
        private int _GroupControlNumber = 0;
        public int GroupControlNumber
        {
            get { return _GroupControlNumber; }
            set
            {
                _GroupControlNumber = value;
                GS.GroupControlNumber = value;
                GE.GroupControlNumber = value;
            }
        }
        private GS GS;
        private GE GE;

        public FunctionalGroup(int groupControlNumber, TransactionSet transactionSet)
        {
            Initialize(groupControlNumber);
            Add(transactionSet);
        }

        public FunctionalGroup(int groupControlNumber, IEnumerable<TransactionSet> transactionSets)
        {
            Initialize(groupControlNumber);
            foreach (TransactionSet transactionSet in transactionSets)
            {
                Add(transactionSet);
            }
        }

        private void Initialize(int groupControlNumber)
        {
            Children = new List<TransactionSet>();
            GroupControlNumber = groupControlNumber;
        }

        public void Add(TransactionSet transactionSet)
        {
            Children.Add(transactionSet);
            GE.TransactionCount++;
        }

        public void RemoveAt(int index)
        {
            Children.RemoveAt(index);
            GE.TransactionCount--;
        }

        public string ToString(X12Options options)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GS.ToString());
            sb.Append(options.RecordDelimiter);
            foreach (TransactionSet transactionSet in Children)
                sb.Append(transactionSet.ToString());
            sb.Append(GE.ToString());
            sb.Append(options.RecordDelimiter);
            return sb.ToString();
        }
    }
}

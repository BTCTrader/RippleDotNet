﻿
namespace RippleDotNet.Model.Transactions.TransactionTypes
{
    public class SetFeeTransaction : BaseTransaction
    {
        public SetFeeTransaction()
        {
            TransactionType = TransactionType.SetFee;
        }

        public string BaseFee { get; set; }

        public uint ReferenceFeeUnits { get; set; }

        public uint ReserveBase { get; set; }

        public uint ReserveIncrement { get; set; }

        public uint LedgerSequence { get; set; }
    }
}
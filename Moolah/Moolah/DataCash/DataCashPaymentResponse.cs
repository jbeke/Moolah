﻿using System.Xml.Linq;

namespace Moolah.DataCash
{
    public class DataCashPaymentResponse : IPaymentResponse
    {
        public DataCashPaymentResponse(XDocument dataCashResponse)
        {
            DataCashResponse = dataCashResponse;
        }

        public string TransactionReference { get; internal set; }

        public PaymentStatus Status { get; internal set; }

        public string Reason { get; internal set; }

        public XDocument DataCashResponse { get; private set; }
    }
}
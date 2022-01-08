using System;

namespace DemoLibrary
{
    public class OverdraftEventArgs : EventArgs
    {
        public decimal SumNeeded { get; private set; }
        public string MoreInfo { get; private set; }
        public bool CancelTransaction { get; set; }

        public OverdraftEventArgs(decimal sumNeeded, string moreInfo)
        {
            SumNeeded = sumNeeded;
            MoreInfo = moreInfo;
        }
    }
}
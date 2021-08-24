﻿namespace BayMarch.Helper
{
    public class SortModel
    {
        public string ColId { get; set; }
        public string Sort { get; set; }

        public string PairAsSqlExpression
        {
            get
            {
                return $"{ColId} {Sort}";
            }
        }
    }
}

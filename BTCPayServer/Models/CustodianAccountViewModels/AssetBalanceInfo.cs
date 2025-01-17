using System;
using System.Collections.Generic;
using BTCPayServer.Client.Models;

namespace BTCPayServer.Models.CustodianAccountViewModels;

public class AssetBalanceInfo
{
    
    public string Asset { get; set; }
    public decimal? Bid { get; set; }
    public decimal? Ask { get; set; }
    public decimal Qty { get; set; }
    public string FiatAsset { get; set; }
    public string FormattedFiatValue { get; set; }
    public IEnumerable<AssetPairData> TradableAssetPairs { get; set; }
    public bool CanWithdraw { get; set; }
    public bool CanDeposit { get; set; }
    public string FormattedBid { get; set; }
    public string FormattedAsk { get; set; }
}

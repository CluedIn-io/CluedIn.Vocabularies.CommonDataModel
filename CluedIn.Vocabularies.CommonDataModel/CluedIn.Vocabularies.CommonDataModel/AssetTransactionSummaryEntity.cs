using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetTransactionSummaryEntityVocabulary : SimpleVocabulary
    {
        public AssetTransactionSummaryEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetTransactionSummaryEntity";
            KeyPrefix = "commonDataModel.assettransactionsummaryentity";
            KeySeparator = ".";
            Grouping = "/AssetTransactionSummaryEntity";

            AddGroup("Common Data Model AssetTransactionSummaryEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisposalDate = group.Add(new VocabularyKey(nameof(DisposalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportingCurrency = group.Add(new VocabularyKey(nameof(ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetBookAmounts = group.Add(new VocabularyKey(nameof(NetBookAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcquisitionAmounts = group.Add(new VocabularyKey(nameof(AcquisitionAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcquisitionSystemAmounts = group.Add(new VocabularyKey(nameof(AcquisitionSystemAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcquisitionReportingAmounts = group.Add(new VocabularyKey(nameof(AcquisitionReportingAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssetGroup = group.Add(new VocabularyKey(nameof(AssetGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BookId = group.Add(new VocabularyKey(nameof(BookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DepreciationAmounts = group.Add(new VocabularyKey(nameof(DepreciationAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DepreciationSystemAmounts = group.Add(new VocabularyKey(nameof(DepreciationSystemAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DepreciationReportingAmounts = group.Add(new VocabularyKey(nameof(DepreciationReportingAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisposalSystemAmounts = group.Add(new VocabularyKey(nameof(DisposalSystemAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisposalReportingAmounts = group.Add(new VocabularyKey(nameof(DisposalReportingAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisposalAmounts = group.Add(new VocabularyKey(nameof(DisposalAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetBookSystemAmounts = group.Add(new VocabularyKey(nameof(NetBookSystemAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetBookReportingAmounts = group.Add(new VocabularyKey(nameof(NetBookReportingAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisposalTransactionType = group.Add(new VocabularyKey(nameof(DisposalTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey AcquisitionDate { get; private set; }
public VocabularyKey DisposalDate { get; private set; }
public VocabularyKey AccountingCurrency { get; private set; }
public VocabularyKey ReportingCurrency { get; private set; }
public VocabularyKey PostingLayer { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey NetBookAmounts { get; private set; }
public VocabularyKey AcquisitionAmounts { get; private set; }
public VocabularyKey AcquisitionSystemAmounts { get; private set; }
public VocabularyKey AcquisitionReportingAmounts { get; private set; }
public VocabularyKey AssetGroup { get; private set; }
public VocabularyKey AssetId { get; private set; }
public VocabularyKey BookId { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey DepreciationAmounts { get; private set; }
public VocabularyKey DepreciationSystemAmounts { get; private set; }
public VocabularyKey DepreciationReportingAmounts { get; private set; }
public VocabularyKey DisposalSystemAmounts { get; private set; }
public VocabularyKey DisposalReportingAmounts { get; private set; }
public VocabularyKey DisposalAmounts { get; private set; }
public VocabularyKey NetBookSystemAmounts { get; private set; }
public VocabularyKey NetBookReportingAmounts { get; private set; }
public VocabularyKey TransactionCurrencyAmount { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey TransType { get; private set; }
public VocabularyKey DisposalTransactionType { get; private set; }


    }
}
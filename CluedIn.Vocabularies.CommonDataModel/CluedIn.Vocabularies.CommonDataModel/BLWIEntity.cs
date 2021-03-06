using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BLWIEntityVocabulary : SimpleVocabulary
    {
        public BLWIEntityVocabulary()
        {
            VocabularyName = "Common Data Model BLWIEntity";
            KeyPrefix = "commonDataModel.blwientity";
            KeySeparator = ".";
            Grouping = "/BLWIEntity";

            AddGroup("Common Data Model BLWIEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BLWITransaction = group.Add(new VocabularyKey(nameof(BLWITransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionGroupId = group.Add(new VocabularyKey(nameof(CountryRegionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionGroupDescription = group.Add(new VocabularyKey(nameof(CountryRegionGroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionGroupBLWIReporting = group.Add(new VocabularyKey(nameof(CountryRegionGroupBLWIReporting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionGroupRowNumber = group.Add(new VocabularyKey(nameof(CountryRegionGroupRowNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionName = group.Add(new VocabularyKey(nameof(CountryRegionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalAmount = group.Add(new VocabularyKey(nameof(OriginalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SurveyCode = group.Add(new VocabularyKey(nameof(SurveyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurposeCode = group.Add(new VocabularyKey(nameof(PurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoGenerated = group.Add(new VocabularyKey(nameof(AutoGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Included = group.Add(new VocabularyKey(nameof(Included), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportingDate = group.Add(new VocabularyKey(nameof(ReportingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Company { get; private set; }
public VocabularyKey BLWITransaction { get; private set; }
public VocabularyKey AccountNumber { get; private set; }
public VocabularyKey CountryRegionGroupId { get; private set; }
public VocabularyKey CountryRegionGroupDescription { get; private set; }
public VocabularyKey CountryRegionGroupBLWIReporting { get; private set; }
public VocabularyKey CountryRegionGroupRowNumber { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey CountryRegionName { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey AmountInTransactionCurrency { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey OriginalAmount { get; private set; }
public VocabularyKey SurveyCode { get; private set; }
public VocabularyKey PurposeCode { get; private set; }
public VocabularyKey AutoGenerated { get; private set; }
public VocabularyKey Included { get; private set; }
public VocabularyKey ReportingDate { get; private set; }


    }
}
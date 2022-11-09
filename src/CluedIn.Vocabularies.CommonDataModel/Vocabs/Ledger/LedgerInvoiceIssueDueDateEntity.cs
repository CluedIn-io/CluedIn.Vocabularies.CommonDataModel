using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerInvoiceIssueDueDateEntityVocabulary : SimpleVocabulary
    {
        public LedgerInvoiceIssueDueDateEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerInvoiceIssueDueDateEntity";
            KeyPrefix = "commonDataModel.ledgerinvoiceissueduedateentity";
            KeySeparator = ".";
            Grouping = "/LedgerInvoiceIssueDueDateEntity";

            AddGroup("Common Data Model LedgerInvoiceIssueDueDateEntity Details", group =>
            {
                CountryRegionType = group.Add(new VocabularyKey(nameof(CountryRegionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateIntervalCode = group.Add(new VocabularyKey(nameof(DateIntervalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionType { get; private set; }
public VocabularyKey DateIntervalCode { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey Company { get; private set; }


    }
}
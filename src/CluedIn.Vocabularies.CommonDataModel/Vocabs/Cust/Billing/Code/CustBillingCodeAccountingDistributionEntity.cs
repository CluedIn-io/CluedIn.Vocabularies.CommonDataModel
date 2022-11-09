using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustBillingCodeAccountingDistributionEntityVocabulary : SimpleVocabulary
    {
        public CustBillingCodeAccountingDistributionEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustBillingCodeAccountingDistributionEntity";
            KeyPrefix = "commonDataModel.custbillingcodeaccountingdistributionentity";
            KeySeparator = ".";
            Grouping = "/CustBillingCodeAccountingDistributionEntity";

            AddGroup("Common Data Model CustBillingCodeAccountingDistributionEntity Details", group =>
            {
                CustBillingCodeVersion = group.Add(new VocabularyKey(nameof(CustBillingCodeVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustBillingCode = group.Add(new VocabularyKey(nameof(CustBillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustBillingCodeVersion { get; private set; }
public VocabularyKey LedgerAccount { get; private set; }
public VocabularyKey Percent { get; private set; }
public VocabularyKey CustBillingCode { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey BillingCode { get; private set; }
public VocabularyKey LedgerAccountDisplayValue { get; private set; }


    }
}
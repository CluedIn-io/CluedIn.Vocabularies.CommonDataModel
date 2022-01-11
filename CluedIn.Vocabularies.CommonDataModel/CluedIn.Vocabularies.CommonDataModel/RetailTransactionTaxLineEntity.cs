using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionTaxLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionTaxLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionTaxLineEntity";
            KeyPrefix = "commonDataModel.retailtransactiontaxlineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionTaxLineEntity";

            AddGroup("Common Data Model RetailTransactionTaxLineEntity Details", group =>
            {
                TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTaxIncludedInPrice = group.Add(new VocabularyKey(nameof(IsTaxIncludedInPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesLineNumber = group.Add(new VocabularyKey(nameof(SalesLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPercentage = group.Add(new VocabularyKey(nameof(TaxPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsExempt = group.Add(new VocabularyKey(nameof(IsExempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxAmount { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey IsTaxIncludedInPrice { get; private set; }
public VocabularyKey SalesLineNumber { get; private set; }
public VocabularyKey TaxCode { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey TaxPercentage { get; private set; }
public VocabularyKey IsExempt { get; private set; }


    }
}
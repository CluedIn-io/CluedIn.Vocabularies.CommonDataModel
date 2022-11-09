using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCreditMemoEntityVocabulary : SimpleVocabulary
    {
        public RetailCreditMemoEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailCreditMemoEntity";
            KeyPrefix = "commonDataModel.retailcreditmemoentity";
            KeySeparator = ".";
            Grouping = "/RetailCreditMemoEntity";

            AddGroup("Common Data Model RetailCreditMemoEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Applied = group.Add(new VocabularyKey(nameof(Applied), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AppliedAmount = group.Add(new VocabularyKey(nameof(AppliedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntryId = group.Add(new VocabularyKey(nameof(EntryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voided = group.Add(new VocabularyKey(nameof(Voided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Amount { get; private set; }
public VocabularyKey Applied { get; private set; }
public VocabularyKey AppliedAmount { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey EntryId { get; private set; }
public VocabularyKey Voided { get; private set; }


    }
}
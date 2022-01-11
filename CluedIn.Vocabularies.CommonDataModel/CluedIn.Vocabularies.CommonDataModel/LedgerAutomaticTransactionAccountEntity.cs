using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAutomaticTransactionAccountEntityVocabulary : SimpleVocabulary
    {
        public LedgerAutomaticTransactionAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerAutomaticTransactionAccountEntity";
            KeyPrefix = "commonDataModel.ledgerautomatictransactionaccountentity";
            KeySeparator = ".";
            Grouping = "/LedgerAutomaticTransactionAccountEntity";

            AddGroup("Common Data Model LedgerAutomaticTransactionAccountEntity Details", group =>
            {
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PostingType { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }


    }
}
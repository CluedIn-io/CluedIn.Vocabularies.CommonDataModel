using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingTransactionPostingDefinitionGeneralLedgerEntityVocabulary : SimpleVocabulary
    {
        public JournalizingTransactionPostingDefinitionGeneralLedgerEntityVocabulary()
        {
            VocabularyName = "Common Data Model JournalizingTransactionPostingDefinitionGeneralLedgerEntity";
            KeyPrefix = "commonDataModel.journalizingtransactionpostingdefinitiongeneralledgerentity";
            KeySeparator = ".";
            Grouping = "/JournalizingTransactionPostingDefinitionGeneralLedgerEntity";

            AddGroup("Common Data Model JournalizingTransactionPostingDefinitionGeneralLedgerEntity Details", group =>
            {
                FundClass = group.Add(new VocabularyKey(nameof(FundClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerTransactionType = group.Add(new VocabularyKey(nameof(LedgerTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingDefinitionId = group.Add(new VocabularyKey(nameof(PostingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FundClass { get; private set; }
public VocabularyKey PostingDefinition { get; private set; }
public VocabularyKey LedgerTransactionType { get; private set; }
public VocabularyKey PostingDefinitionId { get; private set; }


    }
}
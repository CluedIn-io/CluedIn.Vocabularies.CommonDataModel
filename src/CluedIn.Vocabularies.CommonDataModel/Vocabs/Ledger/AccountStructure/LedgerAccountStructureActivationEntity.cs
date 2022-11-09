using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerAccountStructureActivationEntityVocabulary : SimpleVocabulary
    {
        public LedgerAccountStructureActivationEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerAccountStructureActivationEntity";
            KeyPrefix = "commonDataModel.ledgeraccountstructureactivationentity";
            KeySeparator = ".";
            Grouping = "/LedgerAccountStructureActivationEntity";

            AddGroup("Common Data Model LedgerAccountStructureActivationEntity Details", group =>
            {
                AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DoActivate = group.Add(new VocabularyKey(nameof(DoActivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountStructure { get; private set; }
public VocabularyKey DoActivate { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetParametersProposalJournalNamesEntityVocabulary : SimpleVocabulary
    {
        public AssetParametersProposalJournalNamesEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetParametersProposalJournalNamesEntity";
            KeyPrefix = "commonDataModel.assetparametersproposaljournalnamesentity";
            KeySeparator = ".";
            Grouping = "/AssetParametersProposalJournalNamesEntity";

            AddGroup("Common Data Model AssetParametersProposalJournalNamesEntity Details", group =>
            {
                AssetParameters = group.Add(new VocabularyKey(nameof(AssetParameters), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AssetParameters { get; private set; }
public VocabularyKey JournalName { get; private set; }
public VocabularyKey PostingType { get; private set; }


    }
}
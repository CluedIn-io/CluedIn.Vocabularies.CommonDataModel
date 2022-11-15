using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCompanyChainEntityVocabulary : SimpleVocabulary
    {
        public SmmCompanyChainEntityVocabulary()
        {
            VocabularyName = "Smm Company Chain Entity";
            KeyPrefix = "commonDataModel.smmcompanychainentity";
            KeySeparator = ".";
            Grouping = "/SmmCompanyChainEntity";

            AddGroup("SmmCompanyChainEntity Details", group =>
            {
                ChainName = group.Add(new VocabularyKey(nameof(ChainName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChainDescription = group.Add(new VocabularyKey(nameof(ChainDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChainName { get; private set; }
        public VocabularyKey ChainDescription { get; private set; }
    }
}
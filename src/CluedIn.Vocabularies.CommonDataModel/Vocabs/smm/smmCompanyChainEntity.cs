using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCompanyChainEntityVocabulary : SimpleVocabulary
    {
        public smmCompanyChainEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmCompanyChainEntity";
            KeyPrefix = "commonDataModel.smmcompanychainentity";
            KeySeparator = ".";
            Grouping = "/smmCompanyChainEntity";

            AddGroup("Common Data Model smmCompanyChainEntity Details", group =>
            {
                ChainName = group.Add(new VocabularyKey(nameof(ChainName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChainDescription = group.Add(new VocabularyKey(nameof(ChainDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChainName { get; private set; }
        public VocabularyKey ChainDescription { get; private set; }


    }
}
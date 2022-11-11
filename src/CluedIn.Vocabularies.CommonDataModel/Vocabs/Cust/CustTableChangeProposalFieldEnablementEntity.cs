using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustTableChangeProposalFieldEnablementEntityVocabulary : SimpleVocabulary
    {
        public CustTableChangeProposalFieldEnablementEntityVocabulary()
        {
            VocabularyName = "CustTableChangeProposalFieldEnablementEntity";
            KeyPrefix = "commonDataModel.custtablechangeproposalfieldenablemententity";
            KeySeparator = ".";
            Grouping = "/CustTableChangeProposalFieldEnablementEntity";

            AddGroup("CustTableChangeProposalFieldEnablementEntity Details", group =>
            {
                Field = group.Add(new VocabularyKey(nameof(Field), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEnabled = group.Add(new VocabularyKey(nameof(IsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Field { get; private set; }
        public VocabularyKey IsEnabled { get; private set; }


    }
}
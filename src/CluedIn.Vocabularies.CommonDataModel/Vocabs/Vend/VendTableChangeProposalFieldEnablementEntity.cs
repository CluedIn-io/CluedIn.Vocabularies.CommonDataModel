using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendTableChangeProposalFieldEnablementEntityVocabulary : SimpleVocabulary
    {
        public VendTableChangeProposalFieldEnablementEntityVocabulary()
        {
            VocabularyName = "Vend Table Change Proposal Field Enablement Entity";
            KeyPrefix = "commonDataModel.vendtablechangeproposalfieldenablemententity";
            KeySeparator = ".";
            Grouping = "/VendTableChangeProposalFieldEnablementEntity";

            AddGroup("VendTableChangeProposalFieldEnablementEntity Details", group =>
            {
                Field = group.Add(new VocabularyKey(nameof(Field), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEnabled = group.Add(new VocabularyKey(nameof(IsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Field { get; private set; }
        public VocabularyKey IsEnabled { get; private set; }
    }
}
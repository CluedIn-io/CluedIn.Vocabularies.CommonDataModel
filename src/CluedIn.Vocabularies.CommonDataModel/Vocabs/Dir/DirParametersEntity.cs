using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirParametersEntityVocabulary : SimpleVocabulary
    {
        public DirParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model DirParametersEntity";
            KeyPrefix = "commonDataModel.dirparametersentity";
            KeySeparator = ".";
            Grouping = "/DirParametersEntity";

            AddGroup("Common Data Model DirParametersEntity Details", group =>
            {
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameSequence = group.Add(new VocabularyKey(nameof(NameSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeletePartiesWithNoRole = group.Add(new VocabularyKey(nameof(DeletePartiesWithNoRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDuplicateCheck = group.Add(new VocabularyKey(nameof(UseDuplicateCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DunsDisplayOnAddress = group.Add(new VocabularyKey(nameof(DunsDisplayOnAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DunsCheckUnique = group.Add(new VocabularyKey(nameof(DunsCheckUnique), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPartyType = group.Add(new VocabularyKey(nameof(DefaultPartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableEditForExternallyMaintainedFields = group.Add(new VocabularyKey(nameof(EnableEditForExternallyMaintainedFields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Key { get; private set; }
        public VocabularyKey NameSequence { get; private set; }
        public VocabularyKey DeletePartiesWithNoRole { get; private set; }
        public VocabularyKey UseDuplicateCheck { get; private set; }
        public VocabularyKey DunsDisplayOnAddress { get; private set; }
        public VocabularyKey DunsCheckUnique { get; private set; }
        public VocabularyKey DefaultPartyType { get; private set; }
        public VocabularyKey EnableEditForExternallyMaintainedFields { get; private set; }


    }
}
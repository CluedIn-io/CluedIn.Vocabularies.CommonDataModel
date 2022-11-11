using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventFiscalLIFOJournalNameEntityVocabulary : SimpleVocabulary
    {
        public InventFiscalLIFOJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventFiscalLIFOJournalNameEntity";
            KeyPrefix = "commonDataModel.inventfiscallifojournalnameentity";
            KeySeparator = ".";
            Grouping = "/InventFiscalLIFOJournalNameEntity";

            AddGroup("Common Data Model InventFiscalLIFOJournalNameEntity Details", group =>
            {
                PrivateForUserGroup = group.Add(new VocabularyKey(nameof(PrivateForUserGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeWorkInProgress = group.Add(new VocabularyKey(nameof(IncludeWorkInProgress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseNormalValue = group.Add(new VocabularyKey(nameof(UseNormalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PrivateForUserGroup { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IncludeWorkInProgress { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey UseNormalValue { get; private set; }


    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNameOrgUnitListEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNameOrgUnitListEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFMJournalNameOrgUnitListEntity";
            KeyPrefix = "commonDataModel.cfmjournalnameorgunitlistentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNameOrgUnitListEntity";

            AddGroup("Common Data Model CFMJournalNameOrgUnitListEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey DataArea { get; private set; }


    }
}
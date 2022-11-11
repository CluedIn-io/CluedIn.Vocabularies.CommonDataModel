using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ACOJournalNameEntityVocabulary : SimpleVocabulary
    {
        public ACOJournalNameEntityVocabulary()
        {
            VocabularyName = "ACOJournalNameEntity";
            KeyPrefix = "commonDataModel.acojournalnameentity";
            KeySeparator = ".";
            Grouping = "/ACOJournalNameEntity";

            AddGroup("ACOJournalNameEntity Details", group =>
            {
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivateForUserGroupId = group.Add(new VocabularyKey(nameof(PrivateForUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeleteLinesAfterPostingEnabled = group.Add(new VocabularyKey(nameof(IsDeleteLinesAfterPostingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailLevel = group.Add(new VocabularyKey(nameof(DetailLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable = group.Add(new VocabularyKey(nameof(NumberSequenceTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherChange = group.Add(new VocabularyKey(nameof(VoucherChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectionBy = group.Add(new VocabularyKey(nameof(SelectionBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PrivateForUserGroupId { get; private set; }
        public VocabularyKey IsDeleteLinesAfterPostingEnabled { get; private set; }
        public VocabularyKey DetailLevel { get; private set; }
        public VocabularyKey NumberSequenceTable { get; private set; }
        public VocabularyKey VoucherChange { get; private set; }
        public VocabularyKey SelectionBy { get; private set; }
        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }


    }
}
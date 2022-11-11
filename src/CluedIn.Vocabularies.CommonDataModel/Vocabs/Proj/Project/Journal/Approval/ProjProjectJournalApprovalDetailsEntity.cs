using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectJournalApprovalDetailsEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectJournalApprovalDetailsEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectJournalApprovalDetailsEntity";
            KeyPrefix = "commonDataModel.projprojectjournalapprovaldetailsentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectJournalApprovalDetailsEntity";

            AddGroup("Common Data Model ProjProjectJournalApprovalDetailsEntity Details", group =>
            {
                Editing = group.Add(new VocabularyKey(nameof(Editing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckJournal = group.Add(new VocabularyKey(nameof(CheckJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Group = group.Add(new VocabularyKey(nameof(Group), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReadyForPosting = group.Add(new VocabularyKey(nameof(ReadyForPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusValue = group.Add(new VocabularyKey(nameof(StatusValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Previous = group.Add(new VocabularyKey(nameof(Previous), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Approve = group.Add(new VocabularyKey(nameof(Approve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Next = group.Add(new VocabularyKey(nameof(Next), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Editing { get; private set; }
        public VocabularyKey CheckJournal { get; private set; }
        public VocabularyKey Group { get; private set; }
        public VocabularyKey ReadyForPosting { get; private set; }
        public VocabularyKey StatusValue { get; private set; }
        public VocabularyKey Previous { get; private set; }
        public VocabularyKey Approve { get; private set; }
        public VocabularyKey Next { get; private set; }


    }
}
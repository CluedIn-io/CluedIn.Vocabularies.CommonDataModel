using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectJournalApprovalEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectJournalApprovalEntityVocabulary()
        {
            VocabularyName = "Proj Project Journal Approval Entity";
            KeyPrefix = "commonDataModel.projprojectjournalapprovalentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectJournalApprovalEntity";

            AddGroup("ProjProjectJournalApprovalEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Approve = group.Add(new VocabularyKey(nameof(Approve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Approve { get; private set; }
    }
}
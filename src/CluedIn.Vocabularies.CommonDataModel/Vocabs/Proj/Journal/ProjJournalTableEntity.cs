using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjJournalTableEntityVocabulary : SimpleVocabulary
    {
        public ProjJournalTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjJournalTableEntity";
            KeyPrefix = "commonDataModel.projjournaltableentity";
            KeySeparator = ".";
            Grouping = "/ProjJournalTableEntity";

            AddGroup("Common Data Model ProjJournalTableEntity Details", group =>
            {
                ProjCategory = group.Add(new VocabularyKey(nameof(ProjCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeleteLinesAfterPosting = group.Add(new VocabularyKey(nameof(DeleteLinesAfterPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailSummary = group.Add(new VocabularyKey(nameof(DetailSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjLineProperty = group.Add(new VocabularyKey(nameof(ProjLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Approve = group.Add(new VocabularyKey(nameof(Approve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Txt = group.Add(new VocabularyKey(nameof(Txt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewVoucherBy = group.Add(new VocabularyKey(nameof(NewVoucherBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetVoucherDateTo = group.Add(new VocabularyKey(nameof(SetVoucherDateTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectionBy = group.Add(new VocabularyKey(nameof(SelectionBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceDataArea = group.Add(new VocabularyKey(nameof(NumberSequenceDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedUserId = group.Add(new VocabularyKey(nameof(PostedUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjCategory { get; private set; }
        public VocabularyKey DeleteLinesAfterPosting { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DetailSummary { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey ProjLineProperty { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey ProjectDate { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey Approve { get; private set; }
        public VocabularyKey Txt { get; private set; }
        public VocabularyKey NewVoucherBy { get; private set; }
        public VocabularyKey SetVoucherDateTo { get; private set; }
        public VocabularyKey SelectionBy { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey NumberSequenceDataArea { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }
        public VocabularyKey PostedUserId { get; private set; }
        public VocabularyKey Status { get; private set; }


    }
}
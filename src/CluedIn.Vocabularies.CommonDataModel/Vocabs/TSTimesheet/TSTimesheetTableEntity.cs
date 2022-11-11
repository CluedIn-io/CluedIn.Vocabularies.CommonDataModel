using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TSTimesheetTableEntityVocabulary : SimpleVocabulary
    {
        public TSTimesheetTableEntityVocabulary()
        {
            VocabularyName = "TSTimesheetTableEntity";
            KeyPrefix = "commonDataModel.tstimesheettableentity";
            KeySeparator = ".";
            Grouping = "/TSTimesheetTableEntity";

            AddGroup("TSTimesheetTableEntity Details", group =>
            {
                ApprovalStatus = group.Add(new VocabularyKey(nameof(ApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkflowToBeResubmitted = group.Add(new VocabularyKey(nameof(IsWorkflowToBeResubmitted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingStatus = group.Add(new VocabularyKey(nameof(PostingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimesheetNumber = group.Add(new VocabularyKey(nameof(TimesheetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApprovalStatus { get; private set; }
        public VocabularyKey IsWorkflowToBeResubmitted { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey PostingStatus { get; private set; }
        public VocabularyKey TimesheetNumber { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}
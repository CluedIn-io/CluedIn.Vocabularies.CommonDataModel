using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class AwardVersionVocabulary : SimpleVocabulary
    {
        public AwardVersionVocabulary()
        {
            VocabularyName = "Award Version";
            KeyPrefix = "commonDataModel.awardversion.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/AwardVersion";

            AddGroup("AwardVersion Details for NonProfitCore", group =>
            {
			    AwardDate = group.Add(new VocabularyKey(nameof(AwardDate), "Award Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AwardEndDate = group.Add(new VocabularyKey(nameof(AwardEndDate), "Award End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AwardStartDate = group.Add(new VocabularyKey(nameof(AwardStartDate), "Award Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AwardVersionId = group.Add(new VocabularyKey(nameof(AwardVersionId), "Award Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EnrollmentStartDate = group.Add(new VocabularyKey(nameof(EnrollmentStartDate), "Enrollment Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformanceMeasuresSummary = group.Add(new VocabularyKey(nameof(PerformanceMeasuresSummary), "Performance Measures Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReportingSchedule = group.Add(new VocabularyKey(nameof(ReportingSchedule), "Reporting Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AwardDate { get; private set; }
        public VocabularyKey AwardEndDate { get; private set; }
        public VocabularyKey AwardStartDate { get; private set; }
        public VocabularyKey AwardVersionId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EnrollmentStartDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PerformanceMeasuresSummary { get; private set; }
        public VocabularyKey ReportingSchedule { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
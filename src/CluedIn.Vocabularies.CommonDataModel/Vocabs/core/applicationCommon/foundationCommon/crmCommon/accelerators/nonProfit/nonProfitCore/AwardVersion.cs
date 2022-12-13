using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AwardVersionVocabulary : SimpleVocabulary
    {
        public AwardVersionVocabulary()
        {
            VocabularyName = "Award Version";
            KeyPrefix = "commonDataModel.awardversion";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AwardVersion;

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

            #region Incoming Relationships
            ///Property <see cref="PrimaryContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SubmittedById"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AwardId"/> to Vocab 'Award.cdm.json/Award' with Property 'AwardId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="AwardVersionId"/> from Vocab 'Report.cdm.json/Report' with Property 'AwardVersionId'
            ///Property <see cref="AwardVersionId"/> from Vocab 'Review.cdm.json/Review' with Property 'AwardVersionId'
            ///Property <see cref="AwardVersionId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Report.cdm.json/Report' with Property 'AwardVersionId'
            ///Property <see cref="AwardVersionId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Review.cdm.json/Review' with Property 'AwardVersionId'
            #endregion
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
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
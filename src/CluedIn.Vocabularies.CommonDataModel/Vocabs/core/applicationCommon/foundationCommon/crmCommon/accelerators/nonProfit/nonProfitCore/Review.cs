using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ReviewVocabulary : SimpleVocabulary
    {
        public ReviewVocabulary()
        {
            VocabularyName = "Review";
            KeyPrefix = "commonDataModel.review";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Review;

            AddGroup("Review Details for NonProfitCore", group =>
            {
			    DateSubmitted = group.Add(new VocabularyKey(nameof(DateSubmitted), "Date Submitted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DueDate = group.Add(new VocabularyKey(nameof(DueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewDate = group.Add(new VocabularyKey(nameof(ReviewDate), "Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewerType = group.Add(new VocabularyKey(nameof(ReviewerType), "Reviewer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewId = group.Add(new VocabularyKey(nameof(ReviewId), "Review", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Review Details for NonProfitForSales", group =>
            {

            });
            
            #region Incoming Relationships
            ///Property <see cref="ReviewerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ReviewerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="AwardId"/> to Vocab 'Award.cdm.json/Award' with Property 'AwardId'
            ///Property <see cref="AwardId"/> to Vocab 'Award.cdm.json/Award' with Property 'AwardId'
            ///Property <see cref="AwardVersionId"/> to Vocab 'AwardVersion.cdm.json/AwardVersion' with Property 'AwardVersionId'
            ///Property <see cref="AwardVersionId"/> to Vocab 'AwardVersion.cdm.json/AwardVersion' with Property 'AwardVersionId'
            ///Property <see cref="ReviewDocketId"/> to Vocab 'Docket.cdm.json/Docket' with Property 'DocketId'
            ///Property <see cref="ReviewDocketId"/> to Vocab 'Docket.cdm.json/Docket' with Property 'DocketId'
            ///Property <see cref="ReviewReportId"/> to Vocab 'Report.cdm.json/Report' with Property 'ReportId'
            ///Property <see cref="RequestId"/> to Vocab 'Request.cdm.json/Request' with Property 'RequestId'
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
            
            #endregion
        }

        public VocabularyKey DateSubmitted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReviewDate { get; private set; }
        public VocabularyKey ReviewerType { get; private set; }
        public VocabularyKey ReviewId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}
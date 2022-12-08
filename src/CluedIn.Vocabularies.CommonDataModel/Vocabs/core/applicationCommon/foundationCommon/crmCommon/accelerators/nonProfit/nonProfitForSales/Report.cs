using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitForSales
{
    public class ReportVocabulary : SimpleVocabulary
    {
        public ReportVocabulary()
        {
            VocabularyName = "Report";
            KeyPrefix = "commonDataModel.report.nonprofitforsales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Report;

            AddGroup("Report Details for NonProfitForSales", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Report_LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
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
            ///Property <see cref="AwardId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Award.cdm.json/Award' with Property 'AwardId'
            ///Property <see cref="AwardVersionId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/AwardVersion.cdm.json/AwardVersion' with Property 'AwardVersionId'
            ///Property <see cref="PrimaryContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ReportAccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReportSubmittedById"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RequestId"/> to Vocab 'Request.cdm.json/Request' with Property 'RequestId'
            ///Property <see cref="RequestId"/> to Vocab 'Request.cdm.json/Request' with Property 'RequestId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ReportId"/> from Vocab 'Review.cdm.json/Review' with Property 'ReviewReportId'
            ///Property <see cref="ReportId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Review.cdm.json/Review' with Property 'ReviewReportId'
            #endregion
        }

        
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceManagementParametersEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceManagementParametersEntityVocabulary()
        {
            VocabularyName = "SMA Service Management Parameters Entity";
            KeyPrefix = "commonDataModel.smaservicemanagementparametersentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceManagementParametersEntity";

            AddGroup("SMAServiceManagementParametersEntity Details", group =>
            {
                DefaultServiceAgreementActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultServiceAgreementActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultServiceAgreementGroupId = group.Add(new VocabularyKey(nameof(DefaultServiceAgreementGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultServiceAgreementProjectGroupId = group.Add(new VocabularyKey(nameof(DefaultServiceAgreementProjectGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillServiceObjectCreationAllowDuplicateProductAssociations = group.Add(new VocabularyKey(nameof(WillServiceObjectCreationAllowDuplicateProductAssociations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceOrderServiceAgreementOptional = group.Add(new VocabularyKey(nameof(IsServiceOrderServiceAgreementOptional), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceSchedulingWorkCalendarId = group.Add(new VocabularyKey(nameof(ServiceSchedulingWorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceExpenseProjectJournalNameId = group.Add(new VocabularyKey(nameof(ServiceExpenseProjectJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceFeeProjectJournalNameId = group.Add(new VocabularyKey(nameof(ServiceFeeProjectJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceHouseProjectJournalNameId = group.Add(new VocabularyKey(nameof(ServiceHouseProjectJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceInventoryProjectConsumptionJournalNameId = group.Add(new VocabularyKey(nameof(ServiceInventoryProjectConsumptionJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillServiceRequestCancelationRequireReasonCodeEntry = group.Add(new VocabularyKey(nameof(WillServiceRequestCancelationRequireReasonCodeEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillServiceRequestTimeExceedingRequireReasonCodeEntry = group.Add(new VocabularyKey(nameof(WillServiceRequestTimeExceedingRequireReasonCodeEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderActivityCreationRule = group.Add(new VocabularyKey(nameof(ServiceOrderActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityGenerationServiceOrderStageId = group.Add(new VocabularyKey(nameof(ActivityGenerationServiceOrderStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedServiceOrderActivityCategory = group.Add(new VocabularyKey(nameof(GeneratedServiceOrderActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultServiceOrderActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultServiceOrderActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultServiceOrderActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultServiceOrderActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultServiceAgreementActivityTypeId { get; private set; }
        public VocabularyKey DefaultServiceAgreementGroupId { get; private set; }
        public VocabularyKey DefaultServiceAgreementProjectGroupId { get; private set; }
        public VocabularyKey WillServiceObjectCreationAllowDuplicateProductAssociations { get; private set; }
        public VocabularyKey IsServiceOrderServiceAgreementOptional { get; private set; }
        public VocabularyKey ServiceSchedulingWorkCalendarId { get; private set; }
        public VocabularyKey ServiceExpenseProjectJournalNameId { get; private set; }
        public VocabularyKey ServiceFeeProjectJournalNameId { get; private set; }
        public VocabularyKey ServiceHouseProjectJournalNameId { get; private set; }
        public VocabularyKey ServiceInventoryProjectConsumptionJournalNameId { get; private set; }
        public VocabularyKey WillServiceRequestCancelationRequireReasonCodeEntry { get; private set; }
        public VocabularyKey WillServiceRequestTimeExceedingRequireReasonCodeEntry { get; private set; }
        public VocabularyKey ServiceOrderActivityCreationRule { get; private set; }
        public VocabularyKey ActivityGenerationServiceOrderStageId { get; private set; }
        public VocabularyKey GeneratedServiceOrderActivityCategory { get; private set; }
        public VocabularyKey DefaultServiceOrderActivityTypeId { get; private set; }
        public VocabularyKey DefaultServiceOrderActivityPurpose { get; private set; }
    }
}
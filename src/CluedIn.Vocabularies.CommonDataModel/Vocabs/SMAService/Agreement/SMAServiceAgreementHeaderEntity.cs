using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceAgreementHeaderEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceAgreementHeaderEntityVocabulary()
        {
            VocabularyName = "SMA Service Agreement Header Entity";
            KeyPrefix = "commonDataModel.smaserviceagreementheaderentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceAgreementHeaderEntity";

            AddGroup("SMAServiceAgreementHeaderEntity Details", group =>
            {
                CombineServiceOrderMethod = group.Add(new VocabularyKey(nameof(CombineServiceOrderMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLineActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultLineActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAgreementSuspended = group.Add(new VocabularyKey(nameof(IsAgreementSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredTechnicianPersonnelNumber = group.Add(new VocabularyKey(nameof(PreferredTechnicianPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ProjectCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementDescription = group.Add(new VocabularyKey(nameof(ServiceAgreementDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementEndDate = group.Add(new VocabularyKey(nameof(ServiceAgreementEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementGroupId = group.Add(new VocabularyKey(nameof(ServiceAgreementGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementStartDate = group.Add(new VocabularyKey(nameof(ServiceAgreementStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementId = group.Add(new VocabularyKey(nameof(ServiceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementTemplateGroupId = group.Add(new VocabularyKey(nameof(ServiceAgreementTemplateGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLevelAgreementId = group.Add(new VocabularyKey(nameof(ServiceLevelAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(ServiceResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CombineServiceOrderMethod { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey DefaultLineActivityTypeId { get; private set; }
        public VocabularyKey IsAgreementSuspended { get; private set; }
        public VocabularyKey PreferredTechnicianPersonnelNumber { get; private set; }
        public VocabularyKey ProjectCustomerAccountNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ServiceAgreementDescription { get; private set; }
        public VocabularyKey ServiceAgreementEndDate { get; private set; }
        public VocabularyKey ServiceAgreementGroupId { get; private set; }
        public VocabularyKey ServiceAgreementStartDate { get; private set; }
        public VocabularyKey ServiceAgreementId { get; private set; }
        public VocabularyKey ServiceAgreementTemplateGroupId { get; private set; }
        public VocabularyKey ServiceLevelAgreementId { get; private set; }
        public VocabularyKey ServiceResponsiblePersonnelNumber { get; private set; }
    }
}
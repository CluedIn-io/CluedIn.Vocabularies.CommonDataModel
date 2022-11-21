using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchaseRequisitionHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public PurchaseRequisitionHeaderV2EntityVocabulary()
        {
            VocabularyName = "Purchase Requisition Header V2 Entity";
            KeyPrefix = "commonDataModel.purchaserequisitionheaderv2entity";
            KeySeparator = ".";
            Grouping = "/PurchaseRequisitionHeaderV2Entity";

            AddGroup("PurchaseRequisitionHeaderV2Entity Details", group =>
            {
                RequisitionNumber = group.Add(new VocabularyKey(nameof(RequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionName = group.Add(new VocabularyKey(nameof(RequisitionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreparerRecId = group.Add(new VocabularyKey(nameof(PreparerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreparerPersonnelNumber = group.Add(new VocabularyKey(nameof(PreparerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionStatus = group.Add(new VocabularyKey(nameof(RequisitionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionPurpose = group.Add(new VocabularyKey(nameof(RequisitionPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRequestedDate = group.Add(new VocabularyKey(nameof(DefaultRequestedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultAccountingDate = group.Add(new VocabularyKey(nameof(DefaultAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBusinessJustificationRecId = group.Add(new VocabularyKey(nameof(DefaultBusinessJustificationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBusinessJustificationCode = group.Add(new VocabularyKey(nameof(DefaultBusinessJustificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBusinessJustificationDetails = group.Add(new VocabularyKey(nameof(DefaultBusinessJustificationDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectBuyingLegalEntityRecId = group.Add(new VocabularyKey(nameof(ProjectBuyingLegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectBuyingLegalEntityId = group.Add(new VocabularyKey(nameof(ProjectBuyingLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProjectId = group.Add(new VocabularyKey(nameof(DefaultProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseRequisitionOnHold = group.Add(new VocabularyKey(nameof(IsPurchaseRequisitionOnHold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHoldExplanation = group.Add(new VocabularyKey(nameof(OnHoldExplanation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RequisitionNumber { get; private set; }
        public VocabularyKey RequisitionName { get; private set; }
        public VocabularyKey PreparerRecId { get; private set; }
        public VocabularyKey PreparerPersonnelNumber { get; private set; }
        public VocabularyKey RequisitionStatus { get; private set; }
        public VocabularyKey RequisitionPurpose { get; private set; }
        public VocabularyKey DefaultRequestedDate { get; private set; }
        public VocabularyKey DefaultAccountingDate { get; private set; }
        public VocabularyKey DefaultBusinessJustificationRecId { get; private set; }
        public VocabularyKey DefaultBusinessJustificationCode { get; private set; }
        public VocabularyKey DefaultBusinessJustificationDetails { get; private set; }
        public VocabularyKey ProjectBuyingLegalEntityRecId { get; private set; }
        public VocabularyKey ProjectBuyingLegalEntityId { get; private set; }
        public VocabularyKey DefaultProjectId { get; private set; }
        public VocabularyKey IsPurchaseRequisitionOnHold { get; private set; }
        public VocabularyKey OnHoldExplanation { get; private set; }
    }
}
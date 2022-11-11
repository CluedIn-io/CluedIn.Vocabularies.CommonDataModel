using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityOrderCreationPolicyV2EntityVocabulary : SimpleVocabulary
    {
        public InventQualityOrderCreationPolicyV2EntityVocabulary()
        {
            VocabularyName = "InventQualityOrderCreationPolicyV2Entity";
            KeyPrefix = "commonDataModel.inventqualityordercreationpolicyv2entity";
            KeySeparator = ".";
            Grouping = "/InventQualityOrderCreationPolicyV2Entity";

            AddGroup("InventQualityOrderCreationPolicyV2Entity Details", group =>
            {
                AcceptableQualityLevelPercentage = group.Add(new VocabularyKey(nameof(AcceptableQualityLevelPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockedDocumentationProcess = group.Add(new VocabularyKey(nameof(BlockedDocumentationProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderCreationDocumentationEvent = group.Add(new VocabularyKey(nameof(QualityOrderCreationDocumentationEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSamplingId = group.Add(new VocabularyKey(nameof(ItemSamplingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderCreationPolicyType = group.Add(new VocabularyKey(nameof(QualityOrderCreationPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderFailureCreatingQuantineOrder = group.Add(new VocabularyKey(nameof(IsQualityOrderFailureCreatingQuantineOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderCreationDisplayingMessage = group.Add(new VocabularyKey(nameof(IsQualityOrderCreationDisplayingMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderCreationDocumentationEventStage = group.Add(new VocabularyKey(nameof(QualityOrderCreationDocumentationEventStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestGroupId = group.Add(new VocabularyKey(nameof(QualityTestGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDateTime = group.Add(new VocabularyKey(nameof(EffectiveDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDateTime = group.Add(new VocabularyKey(nameof(ExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WrkCtrCode = group.Add(new VocabularyKey(nameof(WrkCtrCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WrkCtrRelation = group.Add(new VocabularyKey(nameof(WrkCtrRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityGroupId = group.Add(new VocabularyKey(nameof(QualityGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceGroupId = group.Add(new VocabularyKey(nameof(OperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationId = group.Add(new VocabularyKey(nameof(RouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteGroupId = group.Add(new VocabularyKey(nameof(RouteGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationCreationSequenceNumber = group.Add(new VocabularyKey(nameof(AssociationCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AcceptableQualityLevelPercentage { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey BlockedDocumentationProcess { get; private set; }
        public VocabularyKey QualityOrderCreationDocumentationEvent { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey ItemSamplingId { get; private set; }
        public VocabularyKey QualityOrderCreationPolicyType { get; private set; }
        public VocabularyKey IsQualityOrderFailureCreatingQuantineOrder { get; private set; }
        public VocabularyKey IsQualityOrderCreationDisplayingMessage { get; private set; }
        public VocabularyKey QualityOrderCreationDocumentationEventStage { get; private set; }
        public VocabularyKey QualityTestGroupId { get; private set; }
        public VocabularyKey EffectiveDateTime { get; private set; }
        public VocabularyKey ExpirationDateTime { get; private set; }
        public VocabularyKey WrkCtrCode { get; private set; }
        public VocabularyKey WrkCtrRelation { get; private set; }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey CustomerGroupId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey QualityGroupId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey OperationsResourceGroupId { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey RouteOperationId { get; private set; }
        public VocabularyKey RouteGroupId { get; private set; }
        public VocabularyKey AssociationCreationSequenceNumber { get; private set; }


    }
}
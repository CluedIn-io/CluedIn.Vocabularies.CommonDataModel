using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCrossDockEntityVocabulary : SimpleVocabulary
    {
        public RetailCrossDockEntityVocabulary()
        {
            VocabularyName = "Retail Cross Dock Entity";
            KeyPrefix = "commonDataModel.retailcrossdockentity";
            KeySeparator = ".";
            Grouping = "/RetailCrossDockEntity";

            AddGroup("RetailCrossDockEntity Details", group =>
            {
                CrossDockId = group.Add(new VocabularyKey(nameof(CrossDockId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistributionType = group.Add(new VocabularyKey(nameof(DistributionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalCreated = group.Add(new VocabularyKey(nameof(JournalCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationRecId = group.Add(new VocabularyKey(nameof(LocationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseId = group.Add(new VocabularyKey(nameof(PurchaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyNode = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyNode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RespectAssortments = group.Add(new VocabularyKey(nameof(RespectAssortments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderCreated = group.Add(new VocabularyKey(nameof(TransferOrderCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyRelationship_ChildOrganization = group.Add(new VocabularyKey(nameof(OMHierarchyRelationship_ChildOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyRelationship_HierarchyType = group.Add(new VocabularyKey(nameof(OMHierarchyRelationship_HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyValidFrom = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyValidTo = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyTypeName = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(ReplenishmentOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CrossDockId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DistributionType { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey JournalCreated { get; private set; }
        public VocabularyKey LocationRecId { get; private set; }
        public VocabularyKey PurchaseId { get; private set; }
        public VocabularyKey ReplenishmentHierarchyNode { get; private set; }
        public VocabularyKey RespectAssortments { get; private set; }
        public VocabularyKey TransferOrderCreated { get; private set; }
        public VocabularyKey OMHierarchyRelationship_ChildOrganization { get; private set; }
        public VocabularyKey OMHierarchyRelationship_HierarchyType { get; private set; }
        public VocabularyKey ReplenishmentHierarchyValidFrom { get; private set; }
        public VocabularyKey ReplenishmentHierarchyValidTo { get; private set; }
        public VocabularyKey ReplenishmentHierarchyTypeName { get; private set; }
        public VocabularyKey ReplenishmentOrganizationPartyNumber { get; private set; }
    }
}
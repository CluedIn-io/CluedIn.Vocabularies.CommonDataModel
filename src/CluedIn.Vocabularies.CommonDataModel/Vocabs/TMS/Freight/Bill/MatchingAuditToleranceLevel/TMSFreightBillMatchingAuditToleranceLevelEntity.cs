using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightBillMatchingAuditToleranceLevelEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightBillMatchingAuditToleranceLevelEntityVocabulary()
        {
            VocabularyName = "TMS Freight Bill Matching Audit Tolerance Level Entity";
            KeyPrefix = "commonDataModel.tmsfreightbillmatchingaudittolerancelevelentity";
            KeySeparator = ".";
            Grouping = "/TMSFreightBillMatchingAuditToleranceLevelEntity";

            AddGroup("TMSFreightBillMatchingAuditToleranceLevelEntity Details", group =>
            {
                UnderpaymentFreightBillReconcilliationReasonCode = group.Add(new VocabularyKey(nameof(UnderpaymentFreightBillReconcilliationReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToleranceLevelId = group.Add(new VocabularyKey(nameof(ToleranceLevelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAuditToleranceUnitType = group.Add(new VocabularyKey(nameof(MaximumAuditToleranceUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAuditToleranceUnitType = group.Add(new VocabularyKey(nameof(MinimumAuditToleranceUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillTypeId = group.Add(new VocabularyKey(nameof(FreightBillTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverpaymentFreightBillReconcilliationReasonCode = group.Add(new VocabularyKey(nameof(OverpaymentFreightBillReconcilliationReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToleranceSequenceNumber = group.Add(new VocabularyKey(nameof(ToleranceSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAuditToleranceAmount = group.Add(new VocabularyKey(nameof(MinimumAuditToleranceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAuditTolerancePercentage = group.Add(new VocabularyKey(nameof(MinimumAuditTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAuditToleranceAmount = group.Add(new VocabularyKey(nameof(MaximumAuditToleranceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAuditTolerancePercentage = group.Add(new VocabularyKey(nameof(MaximumAuditTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey UnderpaymentFreightBillReconcilliationReasonCode { get; private set; }
        public VocabularyKey ToleranceLevelId { get; private set; }
        public VocabularyKey MaximumAuditToleranceUnitType { get; private set; }
        public VocabularyKey MinimumAuditToleranceUnitType { get; private set; }
        public VocabularyKey ShippingCarrierId { get; private set; }
        public VocabularyKey FreightBillTypeId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey OverpaymentFreightBillReconcilliationReasonCode { get; private set; }
        public VocabularyKey ToleranceSequenceNumber { get; private set; }
        public VocabularyKey MinimumAuditToleranceAmount { get; private set; }
        public VocabularyKey MinimumAuditTolerancePercentage { get; private set; }
        public VocabularyKey MaximumAuditToleranceAmount { get; private set; }
        public VocabularyKey MaximumAuditTolerancePercentage { get; private set; }
    }
}
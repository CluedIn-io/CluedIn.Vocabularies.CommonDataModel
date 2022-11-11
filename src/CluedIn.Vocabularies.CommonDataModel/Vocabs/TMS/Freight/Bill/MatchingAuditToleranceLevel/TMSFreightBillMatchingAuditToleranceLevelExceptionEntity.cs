using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightBillMatchingAuditToleranceLevelExceptionEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightBillMatchingAuditToleranceLevelExceptionEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFreightBillMatchingAuditToleranceLevelExceptionEntity";
            KeyPrefix = "commonDataModel.tmsfreightbillmatchingaudittolerancelevelexceptionentity";
            KeySeparator = ".";
            Grouping = "/TMSFreightBillMatchingAuditToleranceLevelExceptionEntity";

            AddGroup("Common Data Model TMSFreightBillMatchingAuditToleranceLevelExceptionEntity Details", group =>
            {
                FreightBillMatchingAuditToleranceLevelId = group.Add(new VocabularyKey(nameof(FreightBillMatchingAuditToleranceLevelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAuditToleranceUnitType = group.Add(new VocabularyKey(nameof(MaximumAuditToleranceUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAuditToleranceUnitType = group.Add(new VocabularyKey(nameof(MinimumAuditToleranceUnitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBillingGroupId = group.Add(new VocabularyKey(nameof(TransportationBillingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierAccessorialChargeId = group.Add(new VocabularyKey(nameof(ShippingCarrierAccessorialChargeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationHubAccessorialChargeId = group.Add(new VocabularyKey(nameof(TransportationHubAccessorialChargeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAuditToleranceAmount = group.Add(new VocabularyKey(nameof(MaximumAuditToleranceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAuditTolerancePercentage = group.Add(new VocabularyKey(nameof(MaximumAuditTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAuditToleranceAmount = group.Add(new VocabularyKey(nameof(MinimumAuditToleranceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAuditTolerancePercentage = group.Add(new VocabularyKey(nameof(MinimumAuditTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FreightBillMatchingAuditToleranceLevelId { get; private set; }
        public VocabularyKey MaximumAuditToleranceUnitType { get; private set; }
        public VocabularyKey MinimumAuditToleranceUnitType { get; private set; }
        public VocabularyKey TransportationBillingGroupId { get; private set; }
        public VocabularyKey ShippingCarrierAccessorialChargeId { get; private set; }
        public VocabularyKey TransportationHubAccessorialChargeId { get; private set; }
        public VocabularyKey MaximumAuditToleranceAmount { get; private set; }
        public VocabularyKey MaximumAuditTolerancePercentage { get; private set; }
        public VocabularyKey MinimumAuditToleranceAmount { get; private set; }
        public VocabularyKey MinimumAuditTolerancePercentage { get; private set; }


    }
}
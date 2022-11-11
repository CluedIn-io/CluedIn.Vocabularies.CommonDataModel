using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetGroupEntityVocabulary : SimpleVocabulary
    {
        public AssetGroupEntityVocabulary()
        {
            VocabularyName = "AssetGroupEntity";
            KeyPrefix = "commonDataModel.assetgroupentity";
            KeySeparator = ".";
            Grouping = "/AssetGroupEntity";

            AddGroup("AssetGroupEntity Details", group =>
            {
                AssetLocationId = group.Add(new VocabularyKey(nameof(AssetLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutonumberFixedAssets = group.Add(new VocabularyKey(nameof(AutonumberFixedAssets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutonumberBarCodes = group.Add(new VocabularyKey(nameof(AutonumberBarCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeNumberSequenceCode = group.Add(new VocabularyKey(nameof(BarcodeNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeNumberSequenceCompanyId = group.Add(new VocabularyKey(nameof(BarcodeNumberSequenceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCompanyId = group.Add(new VocabularyKey(nameof(NumberSequenceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapitalizationThreshold = group.Add(new VocabularyKey(nameof(CapitalizationThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GISLayerId = group.Add(new VocabularyKey(nameof(GISLayerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetGroupId = group.Add(new VocabularyKey(nameof(FixedAssetGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuredValueFactor = group.Add(new VocabularyKey(nameof(InsuredValueFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MajorTypeId = group.Add(new VocabularyKey(nameof(MajorTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyType = group.Add(new VocabularyKey(nameof(PropertyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacementCostFactor = group.Add(new VocabularyKey(nameof(ReplacementCostFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetClassification = group.Add(new VocabularyKey(nameof(AssetClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredType = group.Add(new VocabularyKey(nameof(DeferredType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSCreditInstallments = group.Add(new VocabularyKey(nameof(ICMSCreditInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LongTermReceivablePISCOFINS = group.Add(new VocabularyKey(nameof(LongTermReceivablePISCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutgoingICMS = group.Add(new VocabularyKey(nameof(OutgoingICMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeForCOFINS = group.Add(new VocabularyKey(nameof(TaxationCodeForCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppropriationMethodForPISCOFINS = group.Add(new VocabularyKey(nameof(AppropriationMethodForPISCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetCreditGroup = group.Add(new VocabularyKey(nameof(FixedAssetCreditGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PISCOFINSCreditsInstallments = group.Add(new VocabularyKey(nameof(PISCOFINSCreditsInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetCreditPurpose = group.Add(new VocabularyKey(nameof(FixedAssetCreditPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeForPIS = group.Add(new VocabularyKey(nameof(TaxationCodeForPIS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssetLocationId { get; private set; }
        public VocabularyKey AutonumberFixedAssets { get; private set; }
        public VocabularyKey AutonumberBarCodes { get; private set; }
        public VocabularyKey BarcodeNumberSequenceCode { get; private set; }
        public VocabularyKey BarcodeNumberSequenceCompanyId { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey NumberSequenceCompanyId { get; private set; }
        public VocabularyKey CapitalizationThreshold { get; private set; }
        public VocabularyKey GISLayerId { get; private set; }
        public VocabularyKey FixedAssetGroupId { get; private set; }
        public VocabularyKey InsuredValueFactor { get; private set; }
        public VocabularyKey MajorTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PropertyType { get; private set; }
        public VocabularyKey ReplacementCostFactor { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey AssetClassification { get; private set; }
        public VocabularyKey DeferredType { get; private set; }
        public VocabularyKey ICMSCreditInstallments { get; private set; }
        public VocabularyKey LongTermReceivablePISCOFINS { get; private set; }
        public VocabularyKey OutgoingICMS { get; private set; }
        public VocabularyKey TaxationCodeForCOFINS { get; private set; }
        public VocabularyKey AppropriationMethodForPISCOFINS { get; private set; }
        public VocabularyKey FixedAssetCreditGroup { get; private set; }
        public VocabularyKey PISCOFINSCreditsInstallments { get; private set; }
        public VocabularyKey FixedAssetCreditPurpose { get; private set; }
        public VocabularyKey TaxationCodeForPIS { get; private set; }


    }
}
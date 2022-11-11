using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BOMBillOfMaterialsVersionV3EntityVocabulary : SimpleVocabulary
    {
        public BOMBillOfMaterialsVersionV3EntityVocabulary()
        {
            VocabularyName = "BOMBillOfMaterialsVersionV3Entity";
            KeyPrefix = "commonDataModel.bombillofmaterialsversionv3entity";
            KeySeparator = ".";
            Grouping = "/BOMBillOfMaterialsVersionV3Entity";

            AddGroup("BOMBillOfMaterialsVersionV3Entity Details", group =>
            {
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverId = group.Add(new VocabularyKey(nameof(ApproverId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSelectedForDesigner = group.Add(new VocabularyKey(nameof(IsSelectedForDesigner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManufacturedItemNumber = group.Add(new VocabularyKey(nameof(ManufacturedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionName = group.Add(new VocabularyKey(nameof(VersionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromCatchWeightQuantity = group.Add(new VocabularyKey(nameof(FromCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightSize = group.Add(new VocabularyKey(nameof(CatchWeightSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey ApproverId { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey IsSelectedForDesigner { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey FromQuantity { get; private set; }
        public VocabularyKey ManufacturedItemNumber { get; private set; }
        public VocabularyKey VersionName { get; private set; }
        public VocabularyKey FromCatchWeightQuantity { get; private set; }
        public VocabularyKey CatchWeightSize { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }


    }
}
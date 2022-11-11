using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BOMItemSpecificBillOfMaterialsHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public BOMItemSpecificBillOfMaterialsHeaderV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model BOMItemSpecificBillOfMaterialsHeaderV2Entity";
            KeyPrefix = "commonDataModel.bomitemspecificbillofmaterialsheaderv2entity";
            KeySeparator = ".";
            Grouping = "/BOMItemSpecificBillOfMaterialsHeaderV2Entity";

            AddGroup("Common Data Model BOMItemSpecificBillOfMaterialsHeaderV2Entity Details", group =>
            {
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverId = group.Add(new VocabularyKey(nameof(ApproverId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMName = group.Add(new VocabularyKey(nameof(BOMName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManufacturedItemNumber = group.Add(new VocabularyKey(nameof(ManufacturedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionBOMId = group.Add(new VocabularyKey(nameof(VersionBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionName = group.Add(new VocabularyKey(nameof(VersionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionSiteId = group.Add(new VocabularyKey(nameof(VersionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionIsApproved = group.Add(new VocabularyKey(nameof(VersionIsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionApproverId = group.Add(new VocabularyKey(nameof(VersionApproverId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey ApproverId { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }
        public VocabularyKey BOMId { get; private set; }
        public VocabularyKey BOMName { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ManufacturedItemNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey VersionBOMId { get; private set; }
        public VocabularyKey VersionName { get; private set; }
        public VocabularyKey VersionSiteId { get; private set; }
        public VocabularyKey VersionIsApproved { get; private set; }
        public VocabularyKey VersionApproverId { get; private set; }


    }
}
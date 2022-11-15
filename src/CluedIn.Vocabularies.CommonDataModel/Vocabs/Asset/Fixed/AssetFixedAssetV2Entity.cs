using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetFixedAssetV2EntityVocabulary : SimpleVocabulary
    {
        public AssetFixedAssetV2EntityVocabulary()
        {
            VocabularyName = "Asset Fixed Asset V2 Entity";
            KeyPrefix = "commonDataModel.assetfixedassetv2entity";
            KeySeparator = ".";
            Grouping = "/AssetFixedAssetV2Entity";

            AddGroup("AssetFixedAssetV2Entity Details", group =>
            {
                Agent = group.Add(new VocabularyKey(nameof(Agent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetActivityCode = group.Add(new VocabularyKey(nameof(AssetActivityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityCode = group.Add(new VocabularyKey(nameof(ActivityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetConditionId = group.Add(new VocabularyKey(nameof(AssetConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarCode = group.Add(new VocabularyKey(nameof(BarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Contact = group.Add(new VocabularyKey(nameof(Contact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonnelNumber = group.Add(new VocabularyKey(nameof(ContactPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartmentOperatingUnitNumber = group.Add(new VocabularyKey(nameof(DepartmentOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartmentSearchName = group.Add(new VocabularyKey(nameof(DepartmentSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalRestrictions = group.Add(new VocabularyKey(nameof(DisposalRestrictions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentLocation = group.Add(new VocabularyKey(nameof(DocumentLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetGroupId = group.Add(new VocabularyKey(nameof(FixedAssetGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GISReferenceNumber = group.Add(new VocabularyKey(nameof(GISReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GuaranteeDate = group.Add(new VocabularyKey(nameof(GuaranteeDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Information1 = group.Add(new VocabularyKey(nameof(Information1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Information2 = group.Add(new VocabularyKey(nameof(Information2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Information3 = group.Add(new VocabularyKey(nameof(Information3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceDate1 = group.Add(new VocabularyKey(nameof(InsuranceDate1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceDate2 = group.Add(new VocabularyKey(nameof(InsuranceDate2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceVendor = group.Add(new VocabularyKey(nameof(InsuranceVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuredAtFairMarketValue = group.Add(new VocabularyKey(nameof(InsuredAtFairMarketValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuredValue = group.Add(new VocabularyKey(nameof(InsuredValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPeriodicValueCostUpdate = group.Add(new VocabularyKey(nameof(LastPeriodicValueCostUpdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastMaintenance = group.Add(new VocabularyKey(nameof(LastMaintenance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeaseNote = group.Add(new VocabularyKey(nameof(LeaseNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetLocationId = group.Add(new VocabularyKey(nameof(AssetLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationMemo = group.Add(new VocabularyKey(nameof(LocationMemo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MajorTypeId = group.Add(new VocabularyKey(nameof(MajorTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Make = group.Add(new VocabularyKey(nameof(Make), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MissingAsset = group.Add(new VocabularyKey(nameof(MissingAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Model = group.Add(new VocabularyKey(nameof(Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelYear = group.Add(new VocabularyKey(nameof(ModelYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextMaintenance = group.Add(new VocabularyKey(nameof(NextMaintenance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParcelID = group.Add(new VocabularyKey(nameof(ParcelID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalInventory = group.Add(new VocabularyKey(nameof(PhysicalInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyAmount = group.Add(new VocabularyKey(nameof(PolicyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyExpirationDate = group.Add(new VocabularyKey(nameof(PolicyExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyNumber = group.Add(new VocabularyKey(nameof(PolicyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyGroupId = group.Add(new VocabularyKey(nameof(PropertyGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyType = group.Add(new VocabularyKey(nameof(PropertyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacementCost = group.Add(new VocabularyKey(nameof(ReplacementCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Responsible = group.Add(new VocabularyKey(nameof(Responsible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(ResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoomNumber = group.Add(new VocabularyKey(nameof(RoomNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortField1Id = group.Add(new VocabularyKey(nameof(SortField1Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortField2Id = group.Add(new VocabularyKey(nameof(SortField2Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortField3Id = group.Add(new VocabularyKey(nameof(SortField3Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalInformation1 = group.Add(new VocabularyKey(nameof(TechnicalInformation1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalInformation2 = group.Add(new VocabularyKey(nameof(TechnicalInformation2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalInformation3 = group.Add(new VocabularyKey(nameof(TechnicalInformation3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Titleholder = group.Add(new VocabularyKey(nameof(Titleholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepGroup = group.Add(new VocabularyKey(nameof(AcceleratedDepGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationFixedAssetEquipmentGroupId = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationFixedAssetEquipmentGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetClassification = group.Add(new VocabularyKey(nameof(AssetClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionTaxationCode = group.Add(new VocabularyKey(nameof(ExceptionTaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredType = group.Add(new VocabularyKey(nameof(DeferredType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionTaxationRateDenominator = group.Add(new VocabularyKey(nameof(ExceptionTaxationRateDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionTaxationRate = group.Add(new VocabularyKey(nameof(ExceptionTaxationRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSecondHand = group.Add(new VocabularyKey(nameof(IsSecondHand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameOfTheLender = group.Add(new VocabularyKey(nameof(NameOfTheLender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRented = group.Add(new VocabularyKey(nameof(IsRented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalAssetNumber = group.Add(new VocabularyKey(nameof(PhysicalAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LongTermReceivableTax = group.Add(new VocabularyKey(nameof(LongTermReceivableTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutgoingICMS = group.Add(new VocabularyKey(nameof(OutgoingICMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSCreditInstallments = group.Add(new VocabularyKey(nameof(ICMSCreditInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferredFromInventory = group.Add(new VocabularyKey(nameof(TransferredFromInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeForCOFINS = group.Add(new VocabularyKey(nameof(TaxationCodeForCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppropriationMethod = group.Add(new VocabularyKey(nameof(AppropriationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetCreditGroup = group.Add(new VocabularyKey(nameof(FixedAssetCreditGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditsInstallments = group.Add(new VocabularyKey(nameof(TaxCreditsInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCreditPurpose = group.Add(new VocabularyKey(nameof(TaxCreditPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeForPIS = group.Add(new VocabularyKey(nameof(TaxationCodeForPIS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishment_BR = group.Add(new VocabularyKey(nameof(FiscalEstablishment_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetSourceType_CN = group.Add(new VocabularyKey(nameof(AssetSourceType_CN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceTypeId = group.Add(new VocabularyKey(nameof(SourceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAssetId = group.Add(new VocabularyKey(nameof(MainAssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionPrice = group.Add(new VocabularyKey(nameof(AcquisitionPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetTypeOfMajorType = group.Add(new VocabularyKey(nameof(AssetTypeOfMajorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibleName = group.Add(new VocabularyKey(nameof(ResponsibleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Agent { get; private set; }
        public VocabularyKey AssetActivityCode { get; private set; }
        public VocabularyKey ActivityCode { get; private set; }
        public VocabularyKey AssetConditionId { get; private set; }
        public VocabularyKey BarCode { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Contact { get; private set; }
        public VocabularyKey ContactPersonnelNumber { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey DepartmentOperatingUnitNumber { get; private set; }
        public VocabularyKey DepartmentSearchName { get; private set; }
        public VocabularyKey DisposalRestrictions { get; private set; }
        public VocabularyKey DocumentLocation { get; private set; }
        public VocabularyKey FixedAssetGroupId { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey GISReferenceNumber { get; private set; }
        public VocabularyKey GuaranteeDate { get; private set; }
        public VocabularyKey Information1 { get; private set; }
        public VocabularyKey Information2 { get; private set; }
        public VocabularyKey Information3 { get; private set; }
        public VocabularyKey InsuranceDate1 { get; private set; }
        public VocabularyKey InsuranceDate2 { get; private set; }
        public VocabularyKey InsuranceVendor { get; private set; }
        public VocabularyKey InsuredAtFairMarketValue { get; private set; }
        public VocabularyKey InsuredValue { get; private set; }
        public VocabularyKey LastPeriodicValueCostUpdate { get; private set; }
        public VocabularyKey LastMaintenance { get; private set; }
        public VocabularyKey LeaseNote { get; private set; }
        public VocabularyKey AssetLocationId { get; private set; }
        public VocabularyKey LocationMemo { get; private set; }
        public VocabularyKey MajorTypeId { get; private set; }
        public VocabularyKey Make { get; private set; }
        public VocabularyKey MissingAsset { get; private set; }
        public VocabularyKey Model { get; private set; }
        public VocabularyKey ModelYear { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NextMaintenance { get; private set; }
        public VocabularyKey ParcelID { get; private set; }
        public VocabularyKey PhysicalInventory { get; private set; }
        public VocabularyKey PolicyAmount { get; private set; }
        public VocabularyKey PolicyExpirationDate { get; private set; }
        public VocabularyKey PolicyNumber { get; private set; }
        public VocabularyKey PropertyGroupId { get; private set; }
        public VocabularyKey PropertyType { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey ReplacementCost { get; private set; }
        public VocabularyKey Responsible { get; private set; }
        public VocabularyKey ResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey RoomNumber { get; private set; }
        public VocabularyKey SearchName { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey SortField1Id { get; private set; }
        public VocabularyKey SortField2Id { get; private set; }
        public VocabularyKey SortField3Id { get; private set; }
        public VocabularyKey TechnicalInformation1 { get; private set; }
        public VocabularyKey TechnicalInformation2 { get; private set; }
        public VocabularyKey TechnicalInformation3 { get; private set; }
        public VocabularyKey Titleholder { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey AcceleratedDepGroup { get; private set; }
        public VocabularyKey AcceleratedDepreciationFixedAssetEquipmentGroupId { get; private set; }
        public VocabularyKey AssetClassification { get; private set; }
        public VocabularyKey ExceptionTaxationCode { get; private set; }
        public VocabularyKey DeferredType { get; private set; }
        public VocabularyKey ExceptionTaxationRateDenominator { get; private set; }
        public VocabularyKey ExceptionTaxationRate { get; private set; }
        public VocabularyKey IsSecondHand { get; private set; }
        public VocabularyKey NameOfTheLender { get; private set; }
        public VocabularyKey IsRented { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey PhysicalAssetNumber { get; private set; }
        public VocabularyKey LongTermReceivableTax { get; private set; }
        public VocabularyKey OutgoingICMS { get; private set; }
        public VocabularyKey ICMSCreditInstallments { get; private set; }
        public VocabularyKey TransferredFromInventory { get; private set; }
        public VocabularyKey TaxationCodeForCOFINS { get; private set; }
        public VocabularyKey AppropriationMethod { get; private set; }
        public VocabularyKey FixedAssetCreditGroup { get; private set; }
        public VocabularyKey TaxCreditsInstallments { get; private set; }
        public VocabularyKey TaxCreditPurpose { get; private set; }
        public VocabularyKey TaxationCodeForPIS { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalEstablishment_BR { get; private set; }
        public VocabularyKey AssetSourceType_CN { get; private set; }
        public VocabularyKey SourceTypeId { get; private set; }
        public VocabularyKey MainAssetId { get; private set; }
        public VocabularyKey AcquisitionDate { get; private set; }
        public VocabularyKey AcquisitionPrice { get; private set; }
        public VocabularyKey AssetTypeOfMajorType { get; private set; }
        public VocabularyKey ContactName { get; private set; }
        public VocabularyKey ResponsibleName { get; private set; }
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqItemCoverageSettingsV2EntityVocabulary : SimpleVocabulary
    {
        public ReqItemCoverageSettingsV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqItemCoverageSettingsV2Entity";
            KeyPrefix = "commonDataModel.reqitemcoveragesettingsv2entity";
            KeySeparator = ".";
            Grouping = "/ReqItemCoverageSettingsV2Entity";

            AddGroup("Common Data Model ReqItemCoverageSettingsV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageItemBatchNumber = group.Add(new VocabularyKey(nameof(CoverageItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageProductColorId = group.Add(new VocabularyKey(nameof(CoverageProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageProductSizeId = group.Add(new VocabularyKey(nameof(CoverageProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageProductStyleId = group.Add(new VocabularyKey(nameof(CoverageProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageProductVersionId = group.Add(new VocabularyKey(nameof(CoverageProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageWarehouseId = group.Add(new VocabularyKey(nameof(CoverageWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageItemSerialNumber = group.Add(new VocabularyKey(nameof(CoverageItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageSiteId = group.Add(new VocabularyKey(nameof(CoverageSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageInventoryStatusId = group.Add(new VocabularyKey(nameof(CoverageInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageWarehouseLocationId = group.Add(new VocabularyKey(nameof(CoverageWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageProductConfigurationId = group.Add(new VocabularyKey(nameof(CoverageProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPlannedOrderTypeOverridden = group.Add(new VocabularyKey(nameof(IsPlannedOrderTypeOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderType = group.Add(new VocabularyKey(nameof(PlannedOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPlannedTransferOrderFromWarehouseId = group.Add(new VocabularyKey(nameof(DefaultPlannedTransferOrderFromWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreGeneralSettingsOverridden = group.Add(new VocabularyKey(nameof(AreGeneralSettingsOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductCoverageGroupId = group.Add(new VocabularyKey(nameof(ProductCoverageGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCoverageGroupSettingsOverridden = group.Add(new VocabularyKey(nameof(AreCoverageGroupSettingsOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageMethod = group.Add(new VocabularyKey(nameof(CoverageMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoveragePeriodDays = group.Add(new VocabularyKey(nameof(CoveragePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverageTimeFenceDays = group.Add(new VocabularyKey(nameof(CoverageTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositiveDays = group.Add(new VocabularyKey(nameof(PositiveDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NegativeDays = group.Add(new VocabularyKey(nameof(NegativeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTimeFencesOverridden = group.Add(new VocabularyKey(nameof(AreTimeFencesOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticFirmingTimeFenceDays = group.Add(new VocabularyKey(nameof(AutomaticFirmingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreezeTimeFenceDays = group.Add(new VocabularyKey(nameof(FreezeTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMOrFormulaExplosionTimeFenceDays = group.Add(new VocabularyKey(nameof(BOMOrFormulaExplosionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacitySchedulingTimeFenceDays = group.Add(new VocabularyKey(nameof(CapacitySchedulingTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedRequisitionTimeFenceDays = group.Add(new VocabularyKey(nameof(ApprovedRequisitionTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumOnHandInventoryQuantity = group.Add(new VocabularyKey(nameof(MinimumOnHandInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumOnHandInventoryQuantity = group.Add(new VocabularyKey(nameof(MaximumOnHandInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumOnHandInventorySafetyKeyId = group.Add(new VocabularyKey(nameof(MinimumOnHandInventorySafetyKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumOnHandInventorySafetyKeyId = group.Add(new VocabularyKey(nameof(MaximumOnHandInventorySafetyKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumOnHandFulfillmentMethod = group.Add(new VocabularyKey(nameof(MinimumOnHandFulfillmentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMinimumOnHandSafetyPeriodUsed = group.Add(new VocabularyKey(nameof(IsMinimumOnHandSafetyPeriodUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanningFormulaItemNumber = group.Add(new VocabularyKey(nameof(PlanningFormulaItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPlanningFormulaPriority = group.Add(new VocabularyKey(nameof(DefaultPlanningFormulaPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentPlanningFormulaPriority = group.Add(new VocabularyKey(nameof(CurrentPlanningFormulaPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPlanningFormulaPriorityChangedDate = group.Add(new VocabularyKey(nameof(LastPlanningFormulaPriorityChangedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsumeOnHandOverridden = group.Add(new VocabularyKey(nameof(IsConsumeOnHandOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumeOnHandInventoryMethod = group.Add(new VocabularyKey(nameof(ConsumeOnHandInventoryMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProcurementLeadTimeOverridden = group.Add(new VocabularyKey(nameof(IsProcurementLeadTimeOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementLeadTimeDays = group.Add(new VocabularyKey(nameof(ProcurementLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProcumentLeadTimeUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsProcumentLeadTimeUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionLeadTimeOverridden = group.Add(new VocabularyKey(nameof(IsProductionLeadTimeOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionLeadTimeDays = group.Add(new VocabularyKey(nameof(ProductionLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionLeadTimeUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsProductionLeadTimeUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransferLeadTimeOverridden = group.Add(new VocabularyKey(nameof(IsTransferLeadTimeOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferLeadTimeDays = group.Add(new VocabularyKey(nameof(TransferLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransferLeadTimeUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsTransferLeadTimeUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey CoverageItemBatchNumber { get; private set; }
        public VocabularyKey CoverageProductColorId { get; private set; }
        public VocabularyKey CoverageProductSizeId { get; private set; }
        public VocabularyKey CoverageProductStyleId { get; private set; }
        public VocabularyKey CoverageProductVersionId { get; private set; }
        public VocabularyKey CoverageWarehouseId { get; private set; }
        public VocabularyKey CoverageItemSerialNumber { get; private set; }
        public VocabularyKey CoverageSiteId { get; private set; }
        public VocabularyKey CoverageInventoryStatusId { get; private set; }
        public VocabularyKey CoverageWarehouseLocationId { get; private set; }
        public VocabularyKey CoverageProductConfigurationId { get; private set; }
        public VocabularyKey IsPlannedOrderTypeOverridden { get; private set; }
        public VocabularyKey PlannedOrderType { get; private set; }
        public VocabularyKey DefaultPlannedTransferOrderFromWarehouseId { get; private set; }
        public VocabularyKey AreGeneralSettingsOverridden { get; private set; }
        public VocabularyKey ProductCoverageGroupId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey AreCoverageGroupSettingsOverridden { get; private set; }
        public VocabularyKey CoverageMethod { get; private set; }
        public VocabularyKey CoveragePeriodDays { get; private set; }
        public VocabularyKey CoverageTimeFenceDays { get; private set; }
        public VocabularyKey PositiveDays { get; private set; }
        public VocabularyKey NegativeDays { get; private set; }
        public VocabularyKey AreTimeFencesOverridden { get; private set; }
        public VocabularyKey AutomaticFirmingTimeFenceDays { get; private set; }
        public VocabularyKey FreezeTimeFenceDays { get; private set; }
        public VocabularyKey BOMOrFormulaExplosionTimeFenceDays { get; private set; }
        public VocabularyKey CapacitySchedulingTimeFenceDays { get; private set; }
        public VocabularyKey ApprovedRequisitionTimeFenceDays { get; private set; }
        public VocabularyKey MinimumOnHandInventoryQuantity { get; private set; }
        public VocabularyKey MaximumOnHandInventoryQuantity { get; private set; }
        public VocabularyKey MinimumOnHandInventorySafetyKeyId { get; private set; }
        public VocabularyKey MaximumOnHandInventorySafetyKeyId { get; private set; }
        public VocabularyKey MinimumOnHandFulfillmentMethod { get; private set; }
        public VocabularyKey IsMinimumOnHandSafetyPeriodUsed { get; private set; }
        public VocabularyKey PlanningFormulaItemNumber { get; private set; }
        public VocabularyKey DefaultPlanningFormulaPriority { get; private set; }
        public VocabularyKey CurrentPlanningFormulaPriority { get; private set; }
        public VocabularyKey LastPlanningFormulaPriorityChangedDate { get; private set; }
        public VocabularyKey IsConsumeOnHandOverridden { get; private set; }
        public VocabularyKey ConsumeOnHandInventoryMethod { get; private set; }
        public VocabularyKey IsProcurementLeadTimeOverridden { get; private set; }
        public VocabularyKey ProcurementLeadTimeDays { get; private set; }
        public VocabularyKey IsProcumentLeadTimeUsingWorkingDays { get; private set; }
        public VocabularyKey IsProductionLeadTimeOverridden { get; private set; }
        public VocabularyKey ProductionLeadTimeDays { get; private set; }
        public VocabularyKey IsProductionLeadTimeUsingWorkingDays { get; private set; }
        public VocabularyKey IsTransferLeadTimeOverridden { get; private set; }
        public VocabularyKey TransferLeadTimeDays { get; private set; }
        public VocabularyKey IsTransferLeadTimeUsingWorkingDays { get; private set; }


    }
}
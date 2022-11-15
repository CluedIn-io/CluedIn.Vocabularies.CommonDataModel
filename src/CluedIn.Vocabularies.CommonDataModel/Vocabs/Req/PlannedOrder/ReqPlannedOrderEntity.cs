using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqPlannedOrderEntityVocabulary : SimpleVocabulary
    {
        public ReqPlannedOrderEntityVocabulary()
        {
            VocabularyName = "Req Planned Order Entity";
            KeyPrefix = "commonDataModel.reqplannedorderentity";
            KeySeparator = ".";
            Grouping = "/ReqPlannedOrderEntity";

            AddGroup("ReqPlannedOrderEntity Details", group =>
            {
                IsLeadTimeUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsLeadTimeUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDirectlyDerivedRequirement = group.Add(new VocabularyKey(nameof(IsDirectlyDerivedRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadTimeDays = group.Add(new VocabularyKey(nameof(LeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RequirementCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementQuantity = group.Add(new VocabularyKey(nameof(RequirementQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderNumber = group.Add(new VocabularyKey(nameof(PlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderType = group.Add(new VocabularyKey(nameof(PlannedOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementDate = group.Add(new VocabularyKey(nameof(RequirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDate = group.Add(new VocabularyKey(nameof(DeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderDate = group.Add(new VocabularyKey(nameof(OrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingStatus = group.Add(new VocabularyKey(nameof(ProcessingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTime = group.Add(new VocabularyKey(nameof(DeliveryTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderTime = group.Add(new VocabularyKey(nameof(OrderTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartDate = group.Add(new VocabularyKey(nameof(ScheduledStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchedulingMethod = group.Add(new VocabularyKey(nameof(SchedulingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderRouteOperationId = group.Add(new VocabularyKey(nameof(PlannedOrderRouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBulkOrder = group.Add(new VocabularyKey(nameof(IsBulkOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanningFormulaItemNumber = group.Add(new VocabularyKey(nameof(PlanningFormulaItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSequencedPlannedBatchOrder = group.Add(new VocabularyKey(nameof(IsSequencedPlannedBatchOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YieldPercentage = group.Add(new VocabularyKey(nameof(YieldPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppendingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(AppendingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseQuantity = group.Add(new VocabularyKey(nameof(PurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppendingTransferOrderNumber = group.Add(new VocabularyKey(nameof(AppendingTransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementSiteId = group.Add(new VocabularyKey(nameof(RequirementSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementWarehouseId = group.Add(new VocabularyKey(nameof(RequirementWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementWarehouseLocationId = group.Add(new VocabularyKey(nameof(RequirementWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanId = group.Add(new VocabularyKey(nameof(RequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanType = group.Add(new VocabularyKey(nameof(RequirementPlanType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementPlanDescription = group.Add(new VocabularyKey(nameof(RequirementPlanDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedOrderModifiedDateTime = group.Add(new VocabularyKey(nameof(PlannedOrderModifiedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsLeadTimeUsingWorkingDays { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey IsDirectlyDerivedRequirement { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LeadTimeDays { get; private set; }
        public VocabularyKey RequirementCatchWeightQuantity { get; private set; }
        public VocabularyKey RequirementQuantity { get; private set; }
        public VocabularyKey PlannedOrderNumber { get; private set; }
        public VocabularyKey PlannedOrderType { get; private set; }
        public VocabularyKey RequirementDate { get; private set; }
        public VocabularyKey DeliveryDate { get; private set; }
        public VocabularyKey OrderDate { get; private set; }
        public VocabularyKey ProcessingStatus { get; private set; }
        public VocabularyKey DeliveryTime { get; private set; }
        public VocabularyKey OrderTime { get; private set; }
        public VocabularyKey ScheduledStartDate { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }
        public VocabularyKey SchedulingMethod { get; private set; }
        public VocabularyKey PlannedOrderRouteOperationId { get; private set; }
        public VocabularyKey IsBulkOrder { get; private set; }
        public VocabularyKey PlanningFormulaItemNumber { get; private set; }
        public VocabularyKey IsSequencedPlannedBatchOrder { get; private set; }
        public VocabularyKey YieldPercentage { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey AppendingPurchaseOrderNumber { get; private set; }
        public VocabularyKey PurchaseQuantity { get; private set; }
        public VocabularyKey PurchaseUnitSymbol { get; private set; }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey AppendingTransferOrderNumber { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey RequirementSiteId { get; private set; }
        public VocabularyKey RequirementWarehouseId { get; private set; }
        public VocabularyKey RequirementWarehouseLocationId { get; private set; }
        public VocabularyKey RequirementPlanId { get; private set; }
        public VocabularyKey RequirementPlanType { get; private set; }
        public VocabularyKey RequirementPlanDescription { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey PlannedOrderModifiedDateTime { get; private set; }
        public VocabularyKey BOMId { get; private set; }
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventDimSetupGridEntityVocabulary : SimpleVocabulary
    {
        public InventDimSetupGridEntityVocabulary()
        {
            VocabularyName = "InventDimSetupGridEntity";
            KeyPrefix = "commonDataModel.inventdimsetupgridentity";
            KeySeparator = ".";
            Grouping = "/InventDimSetupGridEntity";

            AddGroup("InventDimSetupGridEntity Details", group =>
            {
                FieldID = group.Add(new VocabularyKey(nameof(FieldID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderEvent = group.Add(new VocabularyKey(nameof(OrderEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickingWorkbenchBatch = group.Add(new VocabularyKey(nameof(PickingWorkbenchBatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProdBOMRAF = group.Add(new VocabularyKey(nameof(ProdBOMRAF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentItem = group.Add(new VocabularyKey(nameof(ShipmentItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowGridAsset = group.Add(new VocabularyKey(nameof(ShowGridAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillsOfMaterials = group.Add(new VocabularyKey(nameof(BillsOfMaterials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CertificateOfAnalysis = group.Add(new VocabularyKey(nameof(CertificateOfAnalysis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryBlocking = group.Add(new VocabularyKey(nameof(InventoryBlocking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Counting = group.Add(new VocabularyKey(nameof(Counting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryAdjustment = group.Add(new VocabularyKey(nameof(InventoryAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuarantineOrders = group.Add(new VocabularyKey(nameof(QuarantineOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryTransactions = group.Add(new VocabularyKey(nameof(InventoryTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Movement = group.Add(new VocabularyKey(nameof(Movement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transfers = group.Add(new VocabularyKey(nameof(Transfers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonConformances = group.Add(new VocabularyKey(nameof(NonConformances), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowGridProdJournalBOM = group.Add(new VocabularyKey(nameof(ShowGridProdJournalBOM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowGridProdJournalProduction = group.Add(new VocabularyKey(nameof(ShowGridProdJournalProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionLines = group.Add(new VocabularyKey(nameof(ProductionLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrders = group.Add(new VocabularyKey(nameof(ProductionOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemConsumption = group.Add(new VocabularyKey(nameof(ItemConsumption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderLines = group.Add(new VocabularyKey(nameof(PurchaseOrderLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrders = group.Add(new VocabularyKey(nameof(QualityOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderLines = group.Add(new VocabularyKey(nameof(OrderLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationLines = group.Add(new VocabularyKey(nameof(QuotationLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationLinesProject = group.Add(new VocabularyKey(nameof(QuotationLinesProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrders = group.Add(new VocabularyKey(nameof(TransferOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickingLines = group.Add(new VocabularyKey(nameof(PickingLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemArrival = group.Add(new VocabularyKey(nameof(ItemArrival), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionInput = group.Add(new VocabularyKey(nameof(ProductionInput), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnershipChange = group.Add(new VocabularyKey(nameof(InventoryOwnershipChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsignmentReplenishmentOrderLine = group.Add(new VocabularyKey(nameof(ConsignmentReplenishmentOrderLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FieldID { get; private set; }
        public VocabularyKey OrderEvent { get; private set; }
        public VocabularyKey PickingWorkbenchBatch { get; private set; }
        public VocabularyKey ProdBOMRAF { get; private set; }
        public VocabularyKey ShipmentItem { get; private set; }
        public VocabularyKey ShowGridAsset { get; private set; }
        public VocabularyKey BillsOfMaterials { get; private set; }
        public VocabularyKey CertificateOfAnalysis { get; private set; }
        public VocabularyKey InventoryBlocking { get; private set; }
        public VocabularyKey Counting { get; private set; }
        public VocabularyKey InventoryAdjustment { get; private set; }
        public VocabularyKey QuarantineOrders { get; private set; }
        public VocabularyKey InventoryTransactions { get; private set; }
        public VocabularyKey Movement { get; private set; }
        public VocabularyKey Transfers { get; private set; }
        public VocabularyKey NonConformances { get; private set; }
        public VocabularyKey ShowGridProdJournalBOM { get; private set; }
        public VocabularyKey ShowGridProdJournalProduction { get; private set; }
        public VocabularyKey ProductionLines { get; private set; }
        public VocabularyKey ProductionOrders { get; private set; }
        public VocabularyKey ItemConsumption { get; private set; }
        public VocabularyKey PurchaseOrderLines { get; private set; }
        public VocabularyKey QualityOrders { get; private set; }
        public VocabularyKey OrderLines { get; private set; }
        public VocabularyKey QuotationLines { get; private set; }
        public VocabularyKey QuotationLinesProject { get; private set; }
        public VocabularyKey TransferOrders { get; private set; }
        public VocabularyKey PickingLines { get; private set; }
        public VocabularyKey ItemArrival { get; private set; }
        public VocabularyKey ProductionInput { get; private set; }
        public VocabularyKey InventoryOwnershipChange { get; private set; }
        public VocabularyKey ConsignmentReplenishmentOrderLine { get; private set; }


    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatEntityVocabulary : SimpleVocabulary
    {
        public IntrastatEntityVocabulary()
        {
            VocabularyName = "Intrastat Entity";
            KeyPrefix = "commonDataModel.intrastatentity";
            KeySeparator = ".";
            Grouping = "/IntrastatEntity";

            AddGroup("IntrastatEntity Details", group =>
            {
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdditionalUnitsQuantity = group.Add(new VocabularyKey(nameof(AdditionalUnitsQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdditionalUnit = group.Add(new VocabularyKey(nameof(AdditionalUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Compress = group.Add(new VocabularyKey(nameof(Compress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Consignments = group.Add(new VocabularyKey(nameof(Consignments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Container = group.Add(new VocabularyKey(nameof(Container), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Correction = group.Add(new VocabularyKey(nameof(Correction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentAgreement = group.Add(new VocabularyKey(nameof(CurrentAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentBatch = group.Add(new VocabularyKey(nameof(ShipmentBatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryMode = group.Add(new VocabularyKey(nameof(DeliveryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTerms = group.Add(new VocabularyKey(nameof(DeliveryTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LotID = group.Add(new VocabularyKey(nameof(LotID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemType = group.Add(new VocabularyKey(nameof(ItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Log = group.Add(new VocabularyKey(nameof(Log), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesAmount = group.Add(new VocabularyKey(nameof(ChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesPercentage = group.Add(new VocabularyKey(nameof(ChargesPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetWeightByUnit = group.Add(new VocabularyKey(nameof(NetWeightByUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatOrderType = group.Add(new VocabularyKey(nameof(IntrastatOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrigCountryRegionId = group.Add(new VocabularyKey(nameof(OrigCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyOfOrigin = group.Add(new VocabularyKey(nameof(CountyOfOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionSenderReceiver = group.Add(new VocabularyKey(nameof(CountryRegionSenderReceiver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateOfOrigin = group.Add(new VocabularyKey(nameof(StateOfOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateSenderReceiver = group.Add(new VocabularyKey(nameof(StateSenderReceiver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationOfThePackingSlipOrProductReceipt = group.Add(new VocabularyKey(nameof(IdentificationOfThePackingSlipOrProductReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartialConsignment = group.Add(new VocabularyKey(nameof(PartialConsignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Preference = group.Add(new VocabularyKey(nameof(Preference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quarter = group.Add(new VocabularyKey(nameof(Quarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Relation = group.Add(new VocabularyKey(nameof(Relation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticalAdjustmentAmount = group.Add(new VocabularyKey(nameof(IntrastatStatisticalAdjustmentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticalValue = group.Add(new VocabularyKey(nameof(IntrastatStatisticalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsProcedure = group.Add(new VocabularyKey(nameof(StatisticsProcedure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectionCode = group.Add(new VocabularyKey(nameof(DirectionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusTrans = group.Add(new VocabularyKey(nameof(StatusTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TariffNumber = group.Add(new VocabularyKey(nameof(TariffNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentDate = group.Add(new VocabularyKey(nameof(FulfillmentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableID = group.Add(new VocabularyKey(nameof(ReferenceTableID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey(nameof(Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Weight = group.Add(new VocabularyKey(nameof(Weight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionYear = group.Add(new VocabularyKey(nameof(CorrectionYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPId = group.Add(new VocabularyKey(nameof(NGPId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPDescription = group.Add(new VocabularyKey(nameof(NGPDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCode = group.Add(new VocabularyKey(nameof(NGPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityId = group.Add(new VocabularyKey(nameof(CommodityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityAdditionalUnits = group.Add(new VocabularyKey(nameof(CommodityAdditionalUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Commodity = group.Add(new VocabularyKey(nameof(Commodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityName = group.Add(new VocabularyKey(nameof(CommodityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCommodity = group.Add(new VocabularyKey(nameof(ParentCommodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCommodityName = group.Add(new VocabularyKey(nameof(ParentCommodityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAmountTransCur = group.Add(new VocabularyKey(nameof(InvoiceAmountTransCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAmount = group.Add(new VocabularyKey(nameof(InvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceChargesAmountTransCurrency = group.Add(new VocabularyKey(nameof(InvoiceChargesAmountTransCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceChargesAmount = group.Add(new VocabularyKey(nameof(InvoiceChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalChargesAmount = group.Add(new VocabularyKey(nameof(StatisticalChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalAmount = group.Add(new VocabularyKey(nameof(StatisticalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementNumber = group.Add(new VocabularyKey(nameof(StatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalIntrastatRecord = group.Add(new VocabularyKey(nameof(OriginalIntrastatRecord), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsCode = group.Add(new VocabularyKey(nameof(CustomsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliverySchedule = group.Add(new VocabularyKey(nameof(DeliverySchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialMovement = group.Add(new VocabularyKey(nameof(SpecialMovement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendReceiveState = group.Add(new VocabularyKey(nameof(SendReceiveState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscChargePerKg = group.Add(new VocabularyKey(nameof(MiscChargePerKg), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey AdditionalUnitsQuantity { get; private set; }
        public VocabularyKey AdditionalUnit { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey Compress { get; private set; }
        public VocabularyKey Consignments { get; private set; }
        public VocabularyKey Container { get; private set; }
        public VocabularyKey Correction { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey CurrentAgreement { get; private set; }
        public VocabularyKey Module { get; private set; }
        public VocabularyKey Direction { get; private set; }
        public VocabularyKey ShipmentBatch { get; private set; }
        public VocabularyKey DeliveryMode { get; private set; }
        public VocabularyKey DeliveryTerms { get; private set; }
        public VocabularyKey LotID { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey Log { get; private set; }
        public VocabularyKey ChargesAmount { get; private set; }
        public VocabularyKey ChargesPercentage { get; private set; }
        public VocabularyKey Month { get; private set; }
        public VocabularyKey NetWeightByUnit { get; private set; }
        public VocabularyKey IntrastatOrderType { get; private set; }
        public VocabularyKey OrigCountryRegionId { get; private set; }
        public VocabularyKey CountyOfOrigin { get; private set; }
        public VocabularyKey CountryRegionSenderReceiver { get; private set; }
        public VocabularyKey StateOfOrigin { get; private set; }
        public VocabularyKey StateSenderReceiver { get; private set; }
        public VocabularyKey IdentificationOfThePackingSlipOrProductReceipt { get; private set; }
        public VocabularyKey PartialConsignment { get; private set; }
        public VocabularyKey Port { get; private set; }
        public VocabularyKey Preference { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Quarter { get; private set; }
        public VocabularyKey Relation { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey IntrastatStatisticalAdjustmentAmount { get; private set; }
        public VocabularyKey IntrastatStatisticalValue { get; private set; }
        public VocabularyKey StatisticsProcedure { get; private set; }
        public VocabularyKey DirectionCode { get; private set; }
        public VocabularyKey StatusTrans { get; private set; }
        public VocabularyKey TariffNumber { get; private set; }
        public VocabularyKey TransactionCode { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey FulfillmentDate { get; private set; }
        public VocabularyKey Transport { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey ReferenceTableID { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey Weight { get; private set; }
        public VocabularyKey CorrectionYear { get; private set; }
        public VocabularyKey NGPId { get; private set; }
        public VocabularyKey NGPDescription { get; private set; }
        public VocabularyKey NGPCode { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CommodityId { get; private set; }
        public VocabularyKey CommodityAdditionalUnits { get; private set; }
        public VocabularyKey Commodity { get; private set; }
        public VocabularyKey CommodityHierarchyName { get; private set; }
        public VocabularyKey CommodityName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ParentCommodity { get; private set; }
        public VocabularyKey ParentCommodityName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey InvoiceAmountTransCur { get; private set; }
        public VocabularyKey InvoiceAmount { get; private set; }
        public VocabularyKey InvoiceChargesAmountTransCurrency { get; private set; }
        public VocabularyKey InvoiceChargesAmount { get; private set; }
        public VocabularyKey StatisticalChargesAmount { get; private set; }
        public VocabularyKey StatisticalAmount { get; private set; }
        public VocabularyKey StatementNumber { get; private set; }
        public VocabularyKey OriginalIntrastatRecord { get; private set; }
        public VocabularyKey CustomsCode { get; private set; }
        public VocabularyKey PaymentMethod { get; private set; }
        public VocabularyKey DeliverySchedule { get; private set; }
        public VocabularyKey SpecialMovement { get; private set; }
        public VocabularyKey SendReceiveState { get; private set; }
        public VocabularyKey MiscChargePerKg { get; private set; }
    }
}
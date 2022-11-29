using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class FactVocabulary : SimpleVocabulary
    {
        public FactVocabulary()
        {
            VocabularyName = "Fact";
            KeyPrefix = "commonDataModel.fact.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Fact";

            AddGroup("Fact Details for ProjectServiceAutomation", group =>
            {
			    FactId = group.Add(new VocabularyKey(nameof(FactId), "Fact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActChargeableBilledSalesAmount = group.Add(new VocabularyKey(nameof(ActChargeableBilledSalesAmount), "Actual Chargeable Billed Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActChargeableBilledSalesAmountBase = group.Add(new VocabularyKey(nameof(ActChargeableBilledSalesAmountBase), "Actual Chargeable Billed Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActChargeableBilledSalesQuantity = group.Add(new VocabularyKey(nameof(ActChargeableBilledSalesQuantity), "Actual Chargeable Billed Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActChargeableCostAmount = group.Add(new VocabularyKey(nameof(ActChargeableCostAmount), "Actual Chargeable Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActChargeableCostAmountBase = group.Add(new VocabularyKey(nameof(ActChargeableCostAmountBase), "Actual Chargeable Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActChargeableCostQuantity = group.Add(new VocabularyKey(nameof(ActChargeableCostQuantity), "Actual Chargeable Cost Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActChargeableUnbilledSalesAmount = group.Add(new VocabularyKey(nameof(ActChargeableUnbilledSalesAmount), "Actual Chargeable Unbilled Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActChargeableUnbilledSalesAmountBase = group.Add(new VocabularyKey(nameof(ActChargeableUnbilledSalesAmountBase), "Actual Chargeable Unbilled Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActChargeableUnbilledSalesQuantity = group.Add(new VocabularyKey(nameof(ActChargeableUnbilledSalesQuantity), "Actual Chargeable Unbilled Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeBilledSalesAmount = group.Add(new VocabularyKey(nameof(ActNoChargeBilledSalesAmount), "Actual No Charge Billed Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeBilledSalesAmountBase = group.Add(new VocabularyKey(nameof(ActNoChargeBilledSalesAmountBase), "Actual No Charge Billed Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeBilledSalesQuantity = group.Add(new VocabularyKey(nameof(ActNoChargeBilledSalesQuantity), "Actual No Charge Billed Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeCostAmount = group.Add(new VocabularyKey(nameof(ActNoChargeCostAmount), "Actual No Charge Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeCostAmountBase = group.Add(new VocabularyKey(nameof(ActNoChargeCostAmountBase), "Actual No Charge Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeCostQuantity = group.Add(new VocabularyKey(nameof(ActNoChargeCostQuantity), "Actual No Charge Cost Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeUnbilledSalesAmount = group.Add(new VocabularyKey(nameof(ActNoChargeUnbilledSalesAmount), "Actual No Charge Unbilled Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeUnbilledSalesAmountBase = group.Add(new VocabularyKey(nameof(ActNoChargeUnbilledSalesAmountBase), "Actual No Charge Unbilled Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActNoChargeUnbilledSalesQuantity = group.Add(new VocabularyKey(nameof(ActNoChargeUnbilledSalesQuantity), "Actual No Charge Unbilled Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActNonChargeableCostAmount = group.Add(new VocabularyKey(nameof(ActNonChargeableCostAmount), "Actual Non Chargeable Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActNonChargeableCostAmountBase = group.Add(new VocabularyKey(nameof(ActNonChargeableCostAmountBase), "Actual Non Chargeable Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActNonChargeableCostQuantity = group.Add(new VocabularyKey(nameof(ActNonChargeableCostQuantity), "Actual Non Chargeable Cost Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActNonChargeableUnbilledSalesAmount = group.Add(new VocabularyKey(nameof(ActNonChargeableUnbilledSalesAmount), "Actual Non Chargeable Unbilled Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ActNonChargeableUnbilledSalesAmountBase = group.Add(new VocabularyKey(nameof(ActNonChargeableUnbilledSalesAmountBase), "Actual Non Chargeable Unbilled Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActNonChargeableUnbilledSalesQuantity = group.Add(new VocabularyKey(nameof(ActNonChargeableUnbilledSalesQuantity), "Actual Non Chargeable Unbilled Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CustomerType = group.Add(new VocabularyKey(nameof(CustomerType), "Customer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), "Document Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstChargeableBilledSalesAmount = group.Add(new VocabularyKey(nameof(EstChargeableBilledSalesAmount), "Estimated Chargeable Billed Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstChargeableBilledSalesAmountBase = group.Add(new VocabularyKey(nameof(EstChargeableBilledSalesAmountBase), "Estimated Chargeable Billed Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstChargeableBilledSalesQuantity = group.Add(new VocabularyKey(nameof(EstChargeableBilledSalesQuantity), "Estimated Chargeable Billed Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstChargeableCostAmount = group.Add(new VocabularyKey(nameof(EstChargeableCostAmount), "Estimated Chargeable Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstChargeableCostAmountBase = group.Add(new VocabularyKey(nameof(EstChargeableCostAmountBase), "Estimated Chargeable Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstChargeableCostQuantity = group.Add(new VocabularyKey(nameof(EstChargeableCostQuantity), "Estimated Chargeable Cost Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstChargeableUnbilledSalesAmount = group.Add(new VocabularyKey(nameof(EstChargeableUnbilledSalesAmount), "Estimated Chargeable Unbilled Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstChargeableUnbilledSalesAmountBase = group.Add(new VocabularyKey(nameof(EstChargeableUnbilledSalesAmountBase), "Estimated Chargeable Unbilled Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstChargeableUnbilledSalesQuantity = group.Add(new VocabularyKey(nameof(EstChargeableUnbilledSalesQuantity), "Estimated Chargeable Unbilled Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeBilledSalesAmount = group.Add(new VocabularyKey(nameof(EstNoChargeBilledSalesAmount), "Estimated No Charge Billed Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeBilledSalesAmountBase = group.Add(new VocabularyKey(nameof(EstNoChargeBilledSalesAmountBase), "Estimated No Charge Billed Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeBilledSalesQuantity = group.Add(new VocabularyKey(nameof(EstNoChargeBilledSalesQuantity), "Estimated No Charge Billed Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeCostAmount = group.Add(new VocabularyKey(nameof(EstNoChargeCostAmount), "Estimated No Charge Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeCostAmountBase = group.Add(new VocabularyKey(nameof(EstNoChargeCostAmountBase), "Estimated No Charge Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeCostQuantity = group.Add(new VocabularyKey(nameof(EstNoChargeCostQuantity), "Estimated No Charge Cost Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeUnbilledSalesAmount = group.Add(new VocabularyKey(nameof(EstNoChargeUnbilledSalesAmount), "Estimated No Charge Unbilled Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeUnbilledSalesAmountBase = group.Add(new VocabularyKey(nameof(EstNoChargeUnbilledSalesAmountBase), "Estimated No Charge Unbilled Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstNoChargeUnbilledSalesQuantity = group.Add(new VocabularyKey(nameof(EstNoChargeUnbilledSalesQuantity), "Estimated No Charge Unbilled Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstNonChargeableCostAmount = group.Add(new VocabularyKey(nameof(EstNonChargeableCostAmount), "Estimated Non Chargeable Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstNonChargeableCostAmountBase = group.Add(new VocabularyKey(nameof(EstNonChargeableCostAmountBase), "Estimated Non Chargeable Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstNonChargeableCostQuantity = group.Add(new VocabularyKey(nameof(EstNonChargeableCostQuantity), "Estimated Non Chargeable Cost Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstNonChargeableUnbilledSalesAmount = group.Add(new VocabularyKey(nameof(EstNonChargeableUnbilledSalesAmount), "Estimated Non Chargeable Unbilled Sales Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EstNonChargeableUnbilledSalesAmountBase = group.Add(new VocabularyKey(nameof(EstNonChargeableUnbilledSalesAmountBase), "Estimated Non Chargeable Unbilled Sales Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstNonChargeableUnbilledSalesQuantity = group.Add(new VocabularyKey(nameof(EstNonChargeableUnbilledSalesQuantity), "Estimated Non Chargeable Unbilled Sales Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    FactType = group.Add(new VocabularyKey(nameof(FactType), "Fact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesContractLine = group.Add(new VocabularyKey(nameof(SalesContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VendorType = group.Add(new VocabularyKey(nameof(VendorType), "Vendor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EarnedRevenue = group.Add(new VocabularyKey(nameof(EarnedRevenue), "Earned Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    EarnedRevenueBase = group.Add(new VocabularyKey(nameof(EarnedRevenueBase), "Earned Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GrossMargin = group.Add(new VocabularyKey(nameof(GrossMargin), "Gross Margin", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    GrossMarginBase = group.Add(new VocabularyKey(nameof(GrossMarginBase), "Gross Margin (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalCost = group.Add(new VocabularyKey(nameof(TotalCost), "Total Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalCostBase = group.Add(new VocabularyKey(nameof(TotalCostBase), "Total Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalHours = group.Add(new VocabularyKey(nameof(TotalHours), "Total Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FactId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ActChargeableBilledSalesAmount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ActChargeableBilledSalesAmountBase { get; private set; }
        public VocabularyKey ActChargeableBilledSalesQuantity { get; private set; }
        public VocabularyKey ActChargeableCostAmount { get; private set; }
        public VocabularyKey ActChargeableCostAmountBase { get; private set; }
        public VocabularyKey ActChargeableCostQuantity { get; private set; }
        public VocabularyKey ActChargeableUnbilledSalesAmount { get; private set; }
        public VocabularyKey ActChargeableUnbilledSalesAmountBase { get; private set; }
        public VocabularyKey ActChargeableUnbilledSalesQuantity { get; private set; }
        public VocabularyKey ActNoChargeBilledSalesAmount { get; private set; }
        public VocabularyKey ActNoChargeBilledSalesAmountBase { get; private set; }
        public VocabularyKey ActNoChargeBilledSalesQuantity { get; private set; }
        public VocabularyKey ActNoChargeCostAmount { get; private set; }
        public VocabularyKey ActNoChargeCostAmountBase { get; private set; }
        public VocabularyKey ActNoChargeCostQuantity { get; private set; }
        public VocabularyKey ActNoChargeUnbilledSalesAmount { get; private set; }
        public VocabularyKey ActNoChargeUnbilledSalesAmountBase { get; private set; }
        public VocabularyKey ActNoChargeUnbilledSalesQuantity { get; private set; }
        public VocabularyKey ActNonChargeableCostAmount { get; private set; }
        public VocabularyKey ActNonChargeableCostAmountBase { get; private set; }
        public VocabularyKey ActNonChargeableCostQuantity { get; private set; }
        public VocabularyKey ActNonChargeableUnbilledSalesAmount { get; private set; }
        public VocabularyKey ActNonChargeableUnbilledSalesAmountBase { get; private set; }
        public VocabularyKey ActNonChargeableUnbilledSalesQuantity { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey EstChargeableBilledSalesAmount { get; private set; }
        public VocabularyKey EstChargeableBilledSalesAmountBase { get; private set; }
        public VocabularyKey EstChargeableBilledSalesQuantity { get; private set; }
        public VocabularyKey EstChargeableCostAmount { get; private set; }
        public VocabularyKey EstChargeableCostAmountBase { get; private set; }
        public VocabularyKey EstChargeableCostQuantity { get; private set; }
        public VocabularyKey EstChargeableUnbilledSalesAmount { get; private set; }
        public VocabularyKey EstChargeableUnbilledSalesAmountBase { get; private set; }
        public VocabularyKey EstChargeableUnbilledSalesQuantity { get; private set; }
        public VocabularyKey EstNoChargeBilledSalesAmount { get; private set; }
        public VocabularyKey EstNoChargeBilledSalesAmountBase { get; private set; }
        public VocabularyKey EstNoChargeBilledSalesQuantity { get; private set; }
        public VocabularyKey EstNoChargeCostAmount { get; private set; }
        public VocabularyKey EstNoChargeCostAmountBase { get; private set; }
        public VocabularyKey EstNoChargeCostQuantity { get; private set; }
        public VocabularyKey EstNoChargeUnbilledSalesAmount { get; private set; }
        public VocabularyKey EstNoChargeUnbilledSalesAmountBase { get; private set; }
        public VocabularyKey EstNoChargeUnbilledSalesQuantity { get; private set; }
        public VocabularyKey EstNonChargeableCostAmount { get; private set; }
        public VocabularyKey EstNonChargeableCostAmountBase { get; private set; }
        public VocabularyKey EstNonChargeableCostQuantity { get; private set; }
        public VocabularyKey EstNonChargeableUnbilledSalesAmount { get; private set; }
        public VocabularyKey EstNonChargeableUnbilledSalesAmountBase { get; private set; }
        public VocabularyKey EstNonChargeableUnbilledSalesQuantity { get; private set; }
        public VocabularyKey FactType { get; private set; }
        public VocabularyKey SalesContractLine { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey VendorType { get; private set; }
        public VocabularyKey EarnedRevenue { get; private set; }
        public VocabularyKey EarnedRevenueBase { get; private set; }
        public VocabularyKey GrossMargin { get; private set; }
        public VocabularyKey GrossMarginBase { get; private set; }
        public VocabularyKey TotalCost { get; private set; }
        public VocabularyKey TotalCostBase { get; private set; }
        public VocabularyKey TotalHours { get; private set; }
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSAActualEntityVocabulary : SimpleVocabulary
    {
        public PSAActualEntityVocabulary()
        {
            VocabularyName = "PSAActualEntity";
            KeyPrefix = "commonDataModel.psaactualentity";
            KeySeparator = ".";
            Grouping = "/PSAActualEntity";

            AddGroup("PSAActualEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMst = group.Add(new VocabularyKey(nameof(AmountMst), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                costSales = group.Add(new VocabularyKey(nameof(costSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmplItemId = group.Add(new VocabularyKey(nameof(EmplItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventTransId = group.Add(new VocabularyKey(nameof(InventTransId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerOrigin = group.Add(new VocabularyKey(nameof(LedgerOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerTransDate = group.Add(new VocabularyKey(nameof(LedgerTransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDate = group.Add(new VocabularyKey(nameof(PaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractId = group.Add(new VocabularyKey(nameof(ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjId = group.Add(new VocabularyKey(nameof(ProjId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjAdjustRefId = group.Add(new VocabularyKey(nameof(ProjAdjustRefId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjFundingSource = group.Add(new VocabularyKey(nameof(ProjFundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjTransDate = group.Add(new VocabularyKey(nameof(ProjTransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjTransType = group.Add(new VocabularyKey(nameof(ProjTransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjType = group.Add(new VocabularyKey(nameof(ProjType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qty = group.Add(new VocabularyKey(nameof(Qty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubscriptionId = group.Add(new VocabularyKey(nameof(SubscriptionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionOrigin = group.Add(new VocabularyKey(nameof(TransactionOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransId = group.Add(new VocabularyKey(nameof(TransId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceLegalEntity = group.Add(new VocabularyKey(nameof(ResourceLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyInfo_PartyNumber = group.Add(new VocabularyKey(nameof(CompanyInfo_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyInfo_DataArea = group.Add(new VocabularyKey(nameof(CompanyInfo_DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjFundingSource_ContractId = group.Add(new VocabularyKey(nameof(ProjFundingSource_ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjFundingSource_FundingSourceId = group.Add(new VocabularyKey(nameof(ProjFundingSource_FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLLaborCost = group.Add(new VocabularyKey(nameof(PLLaborCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLExpenseCost = group.Add(new VocabularyKey(nameof(PLExpenseCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLMaterialCost = group.Add(new VocabularyKey(nameof(PLMaterialCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLCostAccruedLoss = group.Add(new VocabularyKey(nameof(PLCostAccruedLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLTotalCost = group.Add(new VocabularyKey(nameof(PLTotalCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPLaborCost = group.Add(new VocabularyKey(nameof(WIPLaborCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPExpenseCost = group.Add(new VocabularyKey(nameof(WIPExpenseCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPMaterialCost = group.Add(new VocabularyKey(nameof(WIPMaterialCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPCostAccruedLoss = group.Add(new VocabularyKey(nameof(WIPCostAccruedLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPTotalCost = group.Add(new VocabularyKey(nameof(WIPTotalCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedLaborCost = group.Add(new VocabularyKey(nameof(ConsumedLaborCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedLaborQty = group.Add(new VocabularyKey(nameof(ConsumedLaborQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedExpenseCost = group.Add(new VocabularyKey(nameof(ConsumedExpenseCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedMaterialCost = group.Add(new VocabularyKey(nameof(ConsumedMaterialCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalConsumption = group.Add(new VocabularyKey(nameof(totalConsumption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollAllocation = group.Add(new VocabularyKey(nameof(PayrollAllocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LaborInvoicedRevenue = group.Add(new VocabularyKey(nameof(LaborInvoicedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LaborInvoicedQty = group.Add(new VocabularyKey(nameof(LaborInvoicedQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseInvoicedRevenue = group.Add(new VocabularyKey(nameof(ExpenseInvoicedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaterialInvoicedRevenue = group.Add(new VocabularyKey(nameof(MaterialInvoicedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeInvoicedRevenue = group.Add(new VocabularyKey(nameof(FeeInvoicedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnAccPrePayment = group.Add(new VocabularyKey(nameof(OnAccPrePayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnAccDeduction = group.Add(new VocabularyKey(nameof(OnAccDeduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnAccMilestone = group.Add(new VocabularyKey(nameof(OnAccMilestone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnAccBegBal = group.Add(new VocabularyKey(nameof(OnAccBegBal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnAccTotal = group.Add(new VocabularyKey(nameof(OnAccTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLInvoicedRevenue = group.Add(new VocabularyKey(nameof(PLInvoicedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalInvoicedRevenue = group.Add(new VocabularyKey(nameof(totalInvoicedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueSalesValue = group.Add(new VocabularyKey(nameof(PLAccruedRevenueSalesValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueProduction = group.Add(new VocabularyKey(nameof(PLAccruedRevenueProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueProfit = group.Add(new VocabularyKey(nameof(PLAccruedRevenueProfit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueSubscription = group.Add(new VocabularyKey(nameof(PLAccruedRevenueSubscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueOnAcc = group.Add(new VocabularyKey(nameof(PLAccruedRevenueOnAcc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLTotalAccruedRevenue = group.Add(new VocabularyKey(nameof(PLTotalAccruedRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPSalesValue = group.Add(new VocabularyKey(nameof(WIPSalesValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPProduction = group.Add(new VocabularyKey(nameof(WIPProduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPProfit = group.Add(new VocabularyKey(nameof(WIPProfit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPSubscription = group.Add(new VocabularyKey(nameof(WIPSubscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPSalesTotal = group.Add(new VocabularyKey(nameof(WIPSalesTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPInvoicedOnAccount = group.Add(new VocabularyKey(nameof(WIPInvoicedOnAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueSalesValueLabor = group.Add(new VocabularyKey(nameof(PLAccruedRevenueSalesValueLabor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueSalesValueExpense = group.Add(new VocabularyKey(nameof(PLAccruedRevenueSalesValueExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueSalesValueMaterial = group.Add(new VocabularyKey(nameof(PLAccruedRevenueSalesValueMaterial), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLAccruedRevenueSalesValueFee = group.Add(new VocabularyKey(nameof(PLAccruedRevenueSalesValueFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossWIP = group.Add(new VocabularyKey(nameof(GrossWIP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetWIP = group.Add(new VocabularyKey(nameof(NetWIP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLInvoicedRevenueOnAccount = group.Add(new VocabularyKey(nameof(PLInvoicedRevenueOnAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLLaborQty = group.Add(new VocabularyKey(nameof(PLLaborQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLLaborQtyWithoutNoNeverLedger = group.Add(new VocabularyKey(nameof(PLLaborQtyWithoutNoNeverLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLLaborCostWithoutNoNeverLedger = group.Add(new VocabularyKey(nameof(PLLaborCostWithoutNoNeverLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedLaborCostWithoutNoNeverLedger = group.Add(new VocabularyKey(nameof(ConsumedLaborCostWithoutNoNeverLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedLaborQtyWithoutNoNeverLedger = group.Add(new VocabularyKey(nameof(ConsumedLaborQtyWithoutNoNeverLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLMaterialCostWithoutNeverLedger = group.Add(new VocabularyKey(nameof(PLMaterialCostWithoutNeverLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumedMaterialCostWithoutNeverLedger = group.Add(new VocabularyKey(nameof(ConsumedMaterialCostWithoutNeverLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey AmountMst { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey costSales { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey EmplItemId { get; private set; }
        public VocabularyKey InventTransId { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerOrigin { get; private set; }
        public VocabularyKey LedgerTransDate { get; private set; }
        public VocabularyKey PaymentDate { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey ContractId { get; private set; }
        public VocabularyKey ProjId { get; private set; }
        public VocabularyKey ProjAdjustRefId { get; private set; }
        public VocabularyKey ProjFundingSource { get; private set; }
        public VocabularyKey ProjTransDate { get; private set; }
        public VocabularyKey ProjTransType { get; private set; }
        public VocabularyKey ProjType { get; private set; }
        public VocabularyKey Qty { get; private set; }
        public VocabularyKey SubscriptionId { get; private set; }
        public VocabularyKey TransactionOrigin { get; private set; }
        public VocabularyKey TransId { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey ResourceLegalEntity { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CompanyInfo_PartyNumber { get; private set; }
        public VocabularyKey CompanyInfo_DataArea { get; private set; }
        public VocabularyKey ProjFundingSource_ContractId { get; private set; }
        public VocabularyKey ProjFundingSource_FundingSourceId { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey PLLaborCost { get; private set; }
        public VocabularyKey PLExpenseCost { get; private set; }
        public VocabularyKey PLMaterialCost { get; private set; }
        public VocabularyKey PLCostAccruedLoss { get; private set; }
        public VocabularyKey PLTotalCost { get; private set; }
        public VocabularyKey WIPLaborCost { get; private set; }
        public VocabularyKey WIPExpenseCost { get; private set; }
        public VocabularyKey WIPMaterialCost { get; private set; }
        public VocabularyKey WIPCostAccruedLoss { get; private set; }
        public VocabularyKey WIPTotalCost { get; private set; }
        public VocabularyKey ConsumedLaborCost { get; private set; }
        public VocabularyKey ConsumedLaborQty { get; private set; }
        public VocabularyKey ConsumedExpenseCost { get; private set; }
        public VocabularyKey ConsumedMaterialCost { get; private set; }
        public VocabularyKey totalConsumption { get; private set; }
        public VocabularyKey PayrollAllocation { get; private set; }
        public VocabularyKey LaborInvoicedRevenue { get; private set; }
        public VocabularyKey LaborInvoicedQty { get; private set; }
        public VocabularyKey ExpenseInvoicedRevenue { get; private set; }
        public VocabularyKey MaterialInvoicedRevenue { get; private set; }
        public VocabularyKey FeeInvoicedRevenue { get; private set; }
        public VocabularyKey OnAccPrePayment { get; private set; }
        public VocabularyKey OnAccDeduction { get; private set; }
        public VocabularyKey OnAccMilestone { get; private set; }
        public VocabularyKey OnAccBegBal { get; private set; }
        public VocabularyKey OnAccTotal { get; private set; }
        public VocabularyKey PLInvoicedRevenue { get; private set; }
        public VocabularyKey totalInvoicedRevenue { get; private set; }
        public VocabularyKey PLAccruedRevenueSalesValue { get; private set; }
        public VocabularyKey PLAccruedRevenueProduction { get; private set; }
        public VocabularyKey PLAccruedRevenueProfit { get; private set; }
        public VocabularyKey PLAccruedRevenueSubscription { get; private set; }
        public VocabularyKey PLAccruedRevenueOnAcc { get; private set; }
        public VocabularyKey PLTotalAccruedRevenue { get; private set; }
        public VocabularyKey WIPSalesValue { get; private set; }
        public VocabularyKey WIPProduction { get; private set; }
        public VocabularyKey WIPProfit { get; private set; }
        public VocabularyKey WIPSubscription { get; private set; }
        public VocabularyKey WIPSalesTotal { get; private set; }
        public VocabularyKey WIPInvoicedOnAccount { get; private set; }
        public VocabularyKey PLAccruedRevenueSalesValueLabor { get; private set; }
        public VocabularyKey PLAccruedRevenueSalesValueExpense { get; private set; }
        public VocabularyKey PLAccruedRevenueSalesValueMaterial { get; private set; }
        public VocabularyKey PLAccruedRevenueSalesValueFee { get; private set; }
        public VocabularyKey GrossWIP { get; private set; }
        public VocabularyKey NetWIP { get; private set; }
        public VocabularyKey PLInvoicedRevenueOnAccount { get; private set; }
        public VocabularyKey PLLaborQty { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey PLLaborQtyWithoutNoNeverLedger { get; private set; }
        public VocabularyKey PLLaborCostWithoutNoNeverLedger { get; private set; }
        public VocabularyKey ConsumedLaborCostWithoutNoNeverLedger { get; private set; }
        public VocabularyKey ConsumedLaborQtyWithoutNoNeverLedger { get; private set; }
        public VocabularyKey PLMaterialCostWithoutNeverLedger { get; private set; }
        public VocabularyKey ConsumedMaterialCostWithoutNeverLedger { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }


    }
}
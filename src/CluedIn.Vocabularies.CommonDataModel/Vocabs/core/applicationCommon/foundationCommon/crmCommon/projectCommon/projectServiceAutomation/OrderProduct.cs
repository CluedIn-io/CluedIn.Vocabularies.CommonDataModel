using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OrderProductVocabulary : SimpleVocabulary
    {
        public OrderProductVocabulary()
        {
            VocabularyName = "Order Product";
            KeyPrefix = "commonDataModel.orderproduct";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OrderProduct;

            AddGroup("OrderProduct Details for ProjectServiceAutomation", group =>
            {
                BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingStartDate = group.Add(new VocabularyKey(nameof(BillingStartDate), "Billing Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingStatus = group.Add(new VocabularyKey(nameof(BillingStatus), "Billing Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Customer Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), "Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CostAmountBase = group.Add(new VocabularyKey(nameof(CostAmountBase), "Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPricePerUnit = group.Add(new VocabularyKey(nameof(CostPricePerUnit), "Cost Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CostPricePerUnitBase = group.Add(new VocabularyKey(nameof(CostPricePerUnitBase), "Cost Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeExpense = group.Add(new VocabularyKey(nameof(IncludeExpense), "Include Expense", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IncludeFee = group.Add(new VocabularyKey(nameof(IncludeFee), "Include Fee", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IncludeMaterial = group.Add(new VocabularyKey(nameof(IncludeMaterial), "Include Material", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IncludeTime = group.Add(new VocabularyKey(nameof(IncludeTime), "Include Time", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), "Line Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuoteLine = group.Add(new VocabularyKey(nameof(QuoteLine), "(Deprecated) Quote Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("OrderProduct Details for Sales", group =>
            {
                SalesOrderDetailId = group.Add(new VocabularyKey(nameof(SalesOrderDetailId), "Order Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseAmount = group.Add(new VocabularyKey(nameof(BaseAmount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                BaseAmountBase = group.Add(new VocabularyKey(nameof(BaseAmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtendedAmount = group.Add(new VocabularyKey(nameof(ExtendedAmount), "Extended Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExtendedAmountBase = group.Add(new VocabularyKey(nameof(ExtendedAmountBase), "Extended Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCopied = group.Add(new VocabularyKey(nameof(IsCopied), "Copied", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsPriceOverridden = group.Add(new VocabularyKey(nameof(IsPriceOverridden), "Pricing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsProductOverridden = group.Add(new VocabularyKey(nameof(IsProductOverridden), "Select Product", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LineItemNumber = group.Add(new VocabularyKey(nameof(LineItemNumber), "Line Item Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ManualDiscountAmount = group.Add(new VocabularyKey(nameof(ManualDiscountAmount), "Manual Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ManualDiscountAmountBase = group.Add(new VocabularyKey(nameof(ManualDiscountAmountBase), "Manual Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductTypeCode = group.Add(new VocabularyKey(nameof(ProductTypeCode), "Product type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricePerUnit = group.Add(new VocabularyKey(nameof(PricePerUnit), "Price Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                PricePerUnitBase = group.Add(new VocabularyKey(nameof(PricePerUnitBase), "Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingErrorCode = group.Add(new VocabularyKey(nameof(PricingErrorCode), "Pricing Error ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), "Write-In Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), "Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                QuantityBackordered = group.Add(new VocabularyKey(nameof(QuantityBackordered), "Quantity Back Ordered", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                QuantityCancelled = group.Add(new VocabularyKey(nameof(QuantityCancelled), "Quantity Canceled", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                QuantityShipped = group.Add(new VocabularyKey(nameof(QuantityShipped), "Quantity Shipped", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RequestDeliveryBy = group.Add(new VocabularyKey(nameof(RequestDeliveryBy), "Requested Delivery Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderIsPriceLocked = group.Add(new VocabularyKey(nameof(SalesOrderIsPriceLocked), "Order Is Price Locked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SalesOrderStateCode = group.Add(new VocabularyKey(nameof(SalesOrderStateCode), "Order Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToAddressId = group.Add(new VocabularyKey(nameof(ShipToAddressId), "Ship To Address ID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ShipToCity = group.Add(new VocabularyKey(nameof(ShipToCity), "Ship To City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToContactName = group.Add(new VocabularyKey(nameof(ShipToContactName), "Ship To Contact Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToCountry = group.Add(new VocabularyKey(nameof(ShipToCountry), "Ship To Country/Region", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible));
                ShipToFax = group.Add(new VocabularyKey(nameof(ShipToFax), "Ship To Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToFreightTermsCode = group.Add(new VocabularyKey(nameof(ShipToFreightTermsCode), "Freight Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToLine1 = group.Add(new VocabularyKey(nameof(ShipToLine1), "Ship To Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToLine2 = group.Add(new VocabularyKey(nameof(ShipToLine2), "Ship To Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToLine3 = group.Add(new VocabularyKey(nameof(ShipToLine3), "Ship To Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToName = group.Add(new VocabularyKey(nameof(ShipToName), "Ship To Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToPostalCode = group.Add(new VocabularyKey(nameof(ShipToPostalCode), "Ship To ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToStateOrProvince = group.Add(new VocabularyKey(nameof(ShipToStateOrProvince), "Ship To State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipToTelephone = group.Add(new VocabularyKey(nameof(ShipToTelephone), "Ship To Phone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible));
                Tax = group.Add(new VocabularyKey(nameof(Tax), "Tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), "Tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeDiscountAmount = group.Add(new VocabularyKey(nameof(VolumeDiscountAmount), "Volume Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                VolumeDiscountAmountBase = group.Add(new VocabularyKey(nameof(VolumeDiscountAmountBase), "Volume Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCall = group.Add(new VocabularyKey(nameof(WillCall), "Ship To", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), "Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PropertyConfigurationStatus = group.Add(new VocabularyKey(nameof(PropertyConfigurationStatus), "Property Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderDetailName = group.Add(new VocabularyKey(nameof(SalesOrderDetailName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="InvoiceFrequency"/> to Vocab 'InvoiceFrequency.cdm.json/InvoiceFrequency' with Property 'InvoiceFrequencyId'
            ///Property <see cref="SalesOrderId"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ProductAssociationId"/> to Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'ProductAssociationId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="SalesRepId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="QuoteDetailId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="QuoteDetailId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'ContractLineInvoiceSchedule.cdm.json/ContractLineInvoiceSchedule' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'ContractLineScheduleOfValue.cdm.json/ContractLineScheduleOfValue' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'Fact.cdm.json/Fact' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'JournalLine.cdm.json/JournalLine' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineResourceCategory.cdm.json/OrderLineResourceCategory' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineTransactionCategory.cdm.json/OrderLineTransactionCategory' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineTransactionClassification.cdm.json/OrderLineTransactionClassification' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'ParentBundleId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'ParentBundleId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PropertyInstance.cdm.json/PropertyInstance' with Property 'RegardingObjectId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'SalesContractLineId'
            #endregion
        }

        public VocabularyKey BaseAmount { get; private set; }
        public VocabularyKey BaseAmountBase { get; private set; }
        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey BillingStartDate { get; private set; }
        public VocabularyKey BillingStatus { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostAmountBase { get; private set; }
        public VocabularyKey CostPricePerUnit { get; private set; }
        public VocabularyKey CostPricePerUnitBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExtendedAmount { get; private set; }
        public VocabularyKey ExtendedAmountBase { get; private set; }
        public VocabularyKey IncludeExpense { get; private set; }
        public VocabularyKey IncludeFee { get; private set; }
        public VocabularyKey IncludeMaterial { get; private set; }
        public VocabularyKey IncludeTime { get; private set; }
        public VocabularyKey IsCopied { get; private set; }
        public VocabularyKey IsPriceOverridden { get; private set; }
        public VocabularyKey IsProductOverridden { get; private set; }
        public VocabularyKey LineItemNumber { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey ManualDiscountAmount { get; private set; }
        public VocabularyKey ManualDiscountAmountBase { get; private set; }
        public VocabularyKey PricePerUnit { get; private set; }
        public VocabularyKey PricePerUnitBase { get; private set; }
        public VocabularyKey PricingErrorCode { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductTypeCode { get; private set; }
        public VocabularyKey PropertyConfigurationStatus { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey QuantityBackordered { get; private set; }
        public VocabularyKey QuantityCancelled { get; private set; }
        public VocabularyKey QuantityShipped { get; private set; }
        public VocabularyKey QuoteLine { get; private set; }
        public VocabularyKey RequestDeliveryBy { get; private set; }
        public VocabularyKey SalesOrderDetailId { get; private set; }
        public VocabularyKey SalesOrderDetailName { get; private set; }
        public VocabularyKey SalesOrderIsPriceLocked { get; private set; }
        public VocabularyKey SalesOrderStateCode { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey ShipToAddressId { get; private set; }
        public VocabularyKey ShipToCity { get; private set; }
        public VocabularyKey ShipToContactName { get; private set; }
        public VocabularyKey ShipToCountry { get; private set; }
        public VocabularyKey ShipToFax { get; private set; }
        public VocabularyKey ShipToFreightTermsCode { get; private set; }
        public VocabularyKey ShipToLine1 { get; private set; }
        public VocabularyKey ShipToLine2 { get; private set; }
        public VocabularyKey ShipToLine3 { get; private set; }
        public VocabularyKey ShipToName { get; private set; }
        public VocabularyKey ShipToPostalCode { get; private set; }
        public VocabularyKey ShipToStateOrProvince { get; private set; }
        public VocabularyKey ShipToTelephone { get; private set; }
        public VocabularyKey Tax { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey VolumeDiscountAmount { get; private set; }
        public VocabularyKey VolumeDiscountAmountBase { get; private set; }
        public VocabularyKey WillCall { get; private set; }
    }
}
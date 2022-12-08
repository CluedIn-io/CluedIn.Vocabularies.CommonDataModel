using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class OrderVocabulary : SimpleVocabulary
    {
        public OrderVocabulary()
        {
            VocabularyName = "Order";
            KeyPrefix = "commonDataModel.order.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Order;

            AddGroup("Order Details for ProjectServiceAutomation", group =>
            {
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Order Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PSAState = group.Add(new VocabularyKey(nameof(PSAState), "Contract Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PSAStatusReason = group.Add(new VocabularyKey(nameof(PSAStatusReason), "Contract Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollup), "Total Chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollupBase), "Total Chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollup), "Total Non-chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollupBase), "Total Non-chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="SubcontractorAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountCustomer"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountVendor"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="InvoiceFrequency"/> to Vocab 'InvoiceFrequency.cdm.json/InvoiceFrequency' with Property 'InvoiceFrequencyId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PriceLevelId"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="AccountManagerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ContractOrganizationalUnitId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="SalesOrderId"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="SalesContract"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="Contract"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
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
            ///Property <see cref="ContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ContractLineTransactionClassification"/> to Vocab 'OrderLineTransactionClassification.cdm.json/OrderLineTransactionClassification' with Property 'OrderLineTransactionClassificationId'
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
            ///Property <see cref="BookableResource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ContactCustomer"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactVendor"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Origin"/> to Vocab 'OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'OrderLineTransactionId'
            ///Property <see cref="PriceList"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="Product"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ResourceOrganizationalUnitId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="SalesContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="Task"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="Unit"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UnitSchedule"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ContractLineTransactionClassification"/> to Vocab 'OrderLineTransactionClassification.cdm.json/OrderLineTransactionClassification' with Property 'OrderLineTransactionClassificationId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="PriceList"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
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
            ///Property <see cref="PriceLevelId"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="QuoteDetailId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'ContractLineInvoiceSchedule.cdm.json/ContractLineInvoiceSchedule' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderId"/> from Vocab 'ContractLineScheduleOfValue.cdm.json/ContractLineScheduleOfValue' with Property 'ProjectContract'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'ContractLineScheduleOfValue.cdm.json/ContractLineScheduleOfValue' with Property 'ContractLineId'
            ///Property <see cref="SalesOrderId"/> from Vocab 'Fact.cdm.json/Fact' with Property 'SalesContract'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'Fact.cdm.json/Fact' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderId"/> from Vocab 'InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'SalesContract'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="SalesOrderId"/> from Vocab 'JournalLine.cdm.json/JournalLine' with Property 'SalesContract'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'JournalLine.cdm.json/JournalLine' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Project.cdm.json/Project' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/ContactOrders.cdm.json/ContactOrders' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="SalesOrderId"/> from Vocab 'OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'SalesContract'
            ///Property <see cref="SalesOrderId"/> from Vocab 'OrderPriceList.cdm.json/OrderPriceList' with Property 'Contract'
            ///Property <see cref="SalesOrderId"/> from Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> from Vocab 'Project.cdm.json/Project' with Property 'SalesOrderId'
            ///Property <see cref="SalesOrderId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'SalesContract'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineResourceCategory.cdm.json/OrderLineResourceCategory' with Property 'ContractLineId'
            ///Property <see cref="OrderLineTransactionClassificationId"/> from Vocab 'OrderLineResourceCategory.cdm.json/OrderLineResourceCategory' with Property 'ContractLineTransactionClassification'
            ///Property <see cref="OrderLineTransactionId"/> from Vocab 'OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'Origin'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'SalesContractLineId'
            ///Property <see cref="SalesOrderDetailId"/> from Vocab 'OrderLineTransactionCategory.cdm.json/OrderLineTransactionCategory' with Property 'ContractLineId'
            ///Property <see cref="OrderLineTransactionClassificationId"/> from Vocab 'OrderLineTransactionCategory.cdm.json/OrderLineTransactionCategory' with Property 'ContractLineTransactionClassification'
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

        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey PSAState { get; private set; }
        public VocabularyKey PSAStatusReason { get; private set; }
        public VocabularyKey TotalChargeableCostRollup { get; private set; }
        public VocabularyKey TotalChargeableCostRollupBase { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollup { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollupBase { get; private set; }
    }
}
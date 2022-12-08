using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class InvoiceProductVocabulary : SimpleVocabulary
    {
        public InvoiceProductVocabulary()
        {
            VocabularyName = "Invoice Product";
            KeyPrefix = "commonDataModel.invoiceproduct.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.InvoiceProduct;

            AddGroup("InvoiceProduct Details for ProjectServiceAutomation", group =>
            {
			    BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChargeableAmount = group.Add(new VocabularyKey(nameof(ChargeableAmount), "Chargeable Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ChargeableAmountBase = group.Add(new VocabularyKey(nameof(ChargeableAmountBase), "Chargeable Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComplimentaryAmount = group.Add(new VocabularyKey(nameof(ComplimentaryAmount), "Complimentary Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ComplimentaryAmountBase = group.Add(new VocabularyKey(nameof(ComplimentaryAmountBase), "Complimentary Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLineAmount = group.Add(new VocabularyKey(nameof(ContractLineAmount), "Contract Line Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ContractLineAmountBase = group.Add(new VocabularyKey(nameof(ContractLineAmountBase), "Contract Line Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoicedTillDate = group.Add(new VocabularyKey(nameof(InvoicedTillDate), "Amount Previously Invoiced", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InvoicedTillDateBase = group.Add(new VocabularyKey(nameof(InvoicedTillDateBase), "Amount Previously Invoiced (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NonChargeableAmount = group.Add(new VocabularyKey(nameof(NonChargeableAmount), "Non Chargeable Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NonChargeableAmountBase = group.Add(new VocabularyKey(nameof(NonChargeableAmountBase), "Non Chargeable Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="InvoiceId"/> to Vocab 'Invoice.cdm.json/Invoice' with Property 'InvoiceId'
            ///Property <see cref="InvoiceId"/> to Vocab 'Invoice.cdm.json/Invoice' with Property 'InvoiceId'
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
            ///Property <see cref="ParentBundleId"/> to Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'InvoiceDetailId'
            ///Property <see cref="ProductAssociationId"/> to Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'ProductAssociationId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="SalesRepId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="SalesOrderDetailId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'InvoiceDetailId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'InvoiceDetailId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'InvoiceDetailId'
            ///Property <see cref="SalesOrderDetailId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="InvoiceDetailId"/> from Vocab 'InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'InvoiceLineId'
            ///Property <see cref="InvoiceDetailId"/> from Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ParentBundleId'
            ///Property <see cref="InvoiceDetailId"/> from Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="InvoiceDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ParentBundleId'
            ///Property <see cref="InvoiceDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="InvoiceDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PropertyInstance.cdm.json/PropertyInstance' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey ChargeableAmount { get; private set; }
        public VocabularyKey ChargeableAmountBase { get; private set; }
        public VocabularyKey ComplimentaryAmount { get; private set; }
        public VocabularyKey ComplimentaryAmountBase { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey ContractLineAmount { get; private set; }
        public VocabularyKey ContractLineAmountBase { get; private set; }
        public VocabularyKey InvoicedTillDate { get; private set; }
        public VocabularyKey InvoicedTillDateBase { get; private set; }
        public VocabularyKey NonChargeableAmount { get; private set; }
        public VocabularyKey NonChargeableAmountBase { get; private set; }
    }
}
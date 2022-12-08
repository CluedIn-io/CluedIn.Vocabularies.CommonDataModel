using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class ContractLineScheduleOfValueVocabulary : SimpleVocabulary
    {
        public ContractLineScheduleOfValueVocabulary()
        {
            VocabularyName = "Contract Line Schedule Of Value";
            KeyPrefix = "commonDataModel.contractlinescheduleofvalue.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ContractLineScheduleOfValue;

            AddGroup("ContractLineScheduleOfValue Details for ProjectServiceAutomation", group =>
            {
			    ContractLineScheduleOfValueId = group.Add(new VocabularyKey(nameof(ContractLineScheduleOfValueId), "Project Contract Line Milestone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MilestoneName = group.Add(new VocabularyKey(nameof(MilestoneName), "Milestone Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MilestoneAmount = group.Add(new VocabularyKey(nameof(MilestoneAmount), "Line Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLineDescription = group.Add(new VocabularyKey(nameof(ContractLineDescription), "Project Contract Line Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MilestoneDescription = group.Add(new VocabularyKey(nameof(MilestoneDescription), "Milestone Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalDescription = group.Add(new VocabularyKey(nameof(ExternalDescription), "External Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), "Milestone Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceStatus = group.Add(new VocabularyKey(nameof(InvoiceStatus), "Invoice Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Tax = group.Add(new VocabularyKey(nameof(Tax), "tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), "tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionTypeCode = group.Add(new VocabularyKey(nameof(TransactionTypeCode), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountAfterTax = group.Add(new VocabularyKey(nameof(AmountAfterTax), "Milestone Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountAfterTaxBase = group.Add(new VocabularyKey(nameof(AmountAfterTaxBase), "amount_after_tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
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
            ///Property <see cref="ProjectContract"/> to Vocab 'Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="ContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ProjectTask"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContractLineScheduleOfValueId"/> from Vocab 'ContractLineInvoiceSchedule.cdm.json/ContractLineInvoiceSchedule' with Property 'ContractLineScheduleOfValue'
            #endregion
        }

        public VocabularyKey ContractLineScheduleOfValueId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey MilestoneName { get; private set; }
        public VocabularyKey MilestoneAmount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey ContractLineDescription { get; private set; }
        public VocabularyKey MilestoneDescription { get; private set; }
        public VocabularyKey ExternalDescription { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey InvoiceStatus { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Tax { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey TransactionTypeCode { get; private set; }
        public VocabularyKey AmountAfterTax { get; private set; }
        public VocabularyKey AmountAfterTaxBase { get; private set; }
    }
}
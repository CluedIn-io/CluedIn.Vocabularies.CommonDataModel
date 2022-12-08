using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class UnitVocabulary : SimpleVocabulary
    {
        public UnitVocabulary()
        {
            VocabularyName = "Unit";
            KeyPrefix = "commonDataModel.unit.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Unit;

            AddGroup("Unit Details for FoundationCommon", group =>
            {
			    UoMId = group.Add(new VocabularyKey(nameof(UoMId), "Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsScheduleBaseUoM = group.Add(new VocabularyKey(nameof(IsScheduleBaseUoM), "Is Schedule Base Unit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="BaseUoM"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> to Vocab 'UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UoMScheduleId"/> to Vocab 'UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Account.cdm.json/Account' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResource.cdm.json/BookableResource' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResourceCategoryAssn.cdm.json/BookableResourceCategoryAssn' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookableResourceGroup.cdm.json/BookableResourceGroup' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BookingStatus.cdm.json/BookingStatus' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Characteristic.cdm.json/Characteristic' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Company.cdm.json/Company' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'OwningBusinessUnit'
            ///Property <see cref="UoMId"/> from Vocab 'PriceListItem.cdm.json/PriceListItem' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'PriceListItem.cdm.json/PriceListItem' with Property 'UoMScheduleId'
            ///Property <see cref="UoMId"/> from Vocab 'Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'Product.cdm.json/Product' with Property 'DefaultUoMScheduleId'
            ///Property <see cref="UoMId"/> from Vocab 'ProductAssociation.cdm.json/ProductAssociation' with Property 'UoMId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'PropertyInstance.cdm.json/PropertyInstance' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'RatingModel.cdm.json/RatingModel' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'RatingValue.cdm.json/RatingValue' with Property 'OwningBusinessUnit'
            ///Property <see cref="UoMId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'BaseUoM'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'UoMScheduleId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OrderProduct.cdm.json/OrderProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/PriceList.cdm.json/PriceList' with Property 'TimeUnit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/QuoteProduct.cdm.json/QuoteProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'PrimaryUnit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionCategory.cdm.json/TransactionCategory' with Property 'DefaultUnit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionCategoryPriceLevel.cdm.json/TransactionCategoryPriceLevel' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionType.cdm.json/TransactionType' with Property 'DefaultUnit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab 'crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/accelerators/automotive/Unit.cdm.json/Unit' with Property 'UoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'DefaultUoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'UnitGroup'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/Product.cdm.json/Product' with Property 'DefaultUoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionCategory.cdm.json/TransactionCategory' with Property 'UnitGroup'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionCategoryPriceLevel.cdm.json/TransactionCategoryPriceLevel' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionType.cdm.json/TransactionType' with Property 'UnitGroup'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'UoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'UoMScheduleId'
            #endregion
        }

        public VocabularyKey UoMId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsScheduleBaseUoM { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
    }
}
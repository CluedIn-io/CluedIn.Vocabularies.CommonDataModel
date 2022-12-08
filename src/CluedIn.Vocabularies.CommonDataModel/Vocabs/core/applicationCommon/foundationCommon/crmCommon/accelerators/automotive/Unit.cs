using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class UnitVocabulary : SimpleVocabulary
    {
        public UnitVocabulary()
        {
            VocabularyName = "Unit";
            KeyPrefix = "commonDataModel.unit.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Unit;

            AddGroup("Unit Details for Automotive", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UnitId = group.Add(new VocabularyKey(nameof(UnitId), "Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="BaseUoM"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="BaseUoM"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UnitId'
            ///Property <see cref="BaseUoM"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AggregateKPIMeasurement.cdm.json/AggregateKPIMeasurement' with Property 'OwningBusinessUnit'
            ///Property <see cref="UnitId"/> from Vocab 'AggregateKPIMeasurement.cdm.json/AggregateKPIMeasurement' with Property 'UnitId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AggregateKPI.cdm.json/AggregateKPI' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AttributeGroup.cdm.json/AttributeGroup' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AttributeOption.cdm.json/AttributeOption' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AttributeType.cdm.json/AttributeType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Business.cdm.json/Business' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BusinessFacility.cdm.json/BusinessFacility' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BusinessType.cdm.json/BusinessType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ConfigurationCode.cdm.json/ConfigurationCode' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ConfigurationOption.cdm.json/ConfigurationOption' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'CustomerAttachment.cdm.json/CustomerAttachment' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'CustomerIdentifier.cdm.json/CustomerIdentifier' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'CustomerIdentifierType.cdm.json/CustomerIdentifierType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Deal.cdm.json/Deal' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealCustomer.cdm.json/DealCustomer' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealDevice.cdm.json/DealDevice' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealDeviceAddOn.cdm.json/DealDeviceAddOn' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealerPlate.cdm.json/DealerPlate' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealerPlateDeviceAssignment.cdm.json/DealerPlateDeviceAssignment' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealFile.cdm.json/DealFile' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealTerm.cdm.json/DealTerm' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DealType.cdm.json/DealType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Device.cdm.json/Device' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceBrand.cdm.json/DeviceBrand' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceClass.cdm.json/DeviceClass' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceComponent.cdm.json/DeviceComponent' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceGeneration.cdm.json/DeviceGeneration' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceInspection.cdm.json/DeviceInspection' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceInspectionChecklist.cdm.json/DeviceInspectionChecklist' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceInspectionChecklistType.cdm.json/DeviceInspectionChecklistType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceLicensePlate.cdm.json/DeviceLicensePlate' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceMeasure.cdm.json/DeviceMeasure' with Property 'OwningBusinessUnit'
            ///Property <see cref="UnitId"/> from Vocab 'DeviceMeasure.cdm.json/DeviceMeasure' with Property 'UnitId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceMeasurement.cdm.json/DeviceMeasurement' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceMeter.cdm.json/DeviceMeter' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceModel.cdm.json/DeviceModel' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceModelCode.cdm.json/DeviceModelCode' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceObservation.cdm.json/DeviceObservation' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceObservationType.cdm.json/DeviceObservationType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceRegistration.cdm.json/DeviceRegistration' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceSensor.cdm.json/DeviceSensor' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceState.cdm.json/DeviceState' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceStyle.cdm.json/DeviceStyle' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceType.cdm.json/DeviceType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceVariant.cdm.json/DeviceVariant' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceWarranty.cdm.json/DeviceWarranty' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'DeviceWarrantyLimit.cdm.json/DeviceWarrantyLimit' with Property 'OwningBusinessUnit'
            ///Property <see cref="UnitId"/> from Vocab 'DeviceWarrantyLimit.cdm.json/DeviceWarrantyLimit' with Property 'UnitId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'FinancingOpportunity.cdm.json/FinancingOpportunity' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'FinancingOpportunityDetail.cdm.json/FinancingOpportunityDetail' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Fleet.cdm.json/Fleet' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'FleetDevice.cdm.json/FleetDevice' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadDevice.cdm.json/LeadDevice' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadDeviceSpecification.cdm.json/LeadDeviceSpecification' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadDisposition.cdm.json/LeadDisposition' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadDispositionActivity.cdm.json/LeadDispositionActivity' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadPriceType.cdm.json/LeadPriceType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadProspect.cdm.json/LeadProspect' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'LeadSpecificationType.cdm.json/LeadSpecificationType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'OperationCode.cdm.json/OperationCode' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'OperationType.cdm.json/OperationType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SalesContract.cdm.json/SalesContract' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SalesContractDetail.cdm.json/SalesContractDetail' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SalesContractPayment.cdm.json/SalesContractPayment' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SalesContractTerm.cdm.json/SalesContractTerm' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SalesContractType.cdm.json/SalesContractType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceAppointment.cdm.json/ServiceAppointment' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceAppointmentType.cdm.json/ServiceAppointmentType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceContract.cdm.json/ServiceContract' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceContractDetail.cdm.json/ServiceContractDetail' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceContractTerm.cdm.json/ServiceContractTerm' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceContractType.cdm.json/ServiceContractType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceOrder.cdm.json/ServiceOrder' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceOrderGroup.cdm.json/ServiceOrderGroup' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceOrderJob.cdm.json/ServiceOrderJob' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceOrderJobDetail.cdm.json/ServiceOrderJobDetail' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceOrderJobType.cdm.json/ServiceOrderJobType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'ServiceOrderType.cdm.json/ServiceOrderType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Specification.cdm.json/Specification' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SpecificationAccessory.cdm.json/SpecificationAccessory' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'SpecificationAttribute.cdm.json/SpecificationAttribute' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'TradeIn.cdm.json/TradeIn' with Property 'OwningBusinessUnit'
            ///Property <see cref="UoMId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'BaseUoM'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'UoMScheduleId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'OwningBusinessUnit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/PriceListItem.cdm.json/PriceListItem' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'BaseUoM'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderProduct.cdm.json/OrderProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/PriceList.cdm.json/PriceList' with Property 'TimeUnit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteProduct.cdm.json/QuoteProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'PrimaryUnit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TransactionCategory.cdm.json/TransactionCategory' with Property 'DefaultUnit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TransactionCategoryPriceLevel.cdm.json/TransactionCategoryPriceLevel' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TransactionType.cdm.json/TransactionType' with Property 'DefaultUnit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'Unit'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'UoMId'
            ///Property <see cref="UnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/PriceListItem.cdm.json/PriceListItem' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'BaseUoM'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderProduct.cdm.json/OrderProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/PriceList.cdm.json/PriceList' with Property 'TimeUnit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Product.cdm.json/Product' with Property 'DefaultUoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteProduct.cdm.json/QuoteProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'PrimaryUnit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TransactionCategory.cdm.json/TransactionCategory' with Property 'DefaultUnit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TransactionCategoryPriceLevel.cdm.json/TransactionCategoryPriceLevel' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TransactionType.cdm.json/TransactionType' with Property 'DefaultUnit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'Unit'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'UoMId'
            ///Property <see cref="UoMId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'UoMId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Warranty.cdm.json/Warranty' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'WarrantyLimit.cdm.json/WarrantyLimit' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'WarrantyType.cdm.json/WarrantyType' with Property 'OwningBusinessUnit'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UnitId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}
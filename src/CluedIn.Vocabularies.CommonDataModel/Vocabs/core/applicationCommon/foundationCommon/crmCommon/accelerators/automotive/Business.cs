using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class BusinessVocabulary : SimpleVocabulary
    {
        public BusinessVocabulary()
        {
            VocabularyName = "Business";
            KeyPrefix = "commonDataModel.business.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Business;

            AddGroup("Business Details for Automotive", group =>
            {
			    BusinessId = group.Add(new VocabularyKey(nameof(BusinessId), "Business", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AccountId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="BusinessTypeId"/> to Vocab 'BusinessType.cdm.json/BusinessType' with Property 'BusinessTypeId'
            ///Property <see cref="ParentBusinessId"/> to Vocab 'Business.cdm.json/Business' with Property 'BusinessId'
            ///Property <see cref="BusinessId"/> to Vocab 'Business.cdm.json/Business' with Property 'BusinessId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AccountId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="FacilityId"/> to Vocab 'BusinessFacility.cdm.json/BusinessFacility' with Property 'BusinessFacilityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AccountId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OperationTypeId"/> to Vocab 'OperationType.cdm.json/OperationType' with Property 'OperationTypeId'
            ///Property <see cref="BusinessOperationId"/> to Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'BusinessOperationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AggregateKPIMeasurement.cdm.json/AggregateKPIMeasurement' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AggregateKPI.cdm.json/AggregateKPI' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AttributeGroup.cdm.json/AttributeGroup' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AttributeOption.cdm.json/AttributeOption' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'AttributeType.cdm.json/AttributeType' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Business.cdm.json/Business' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessTypeId"/> from Vocab 'Business.cdm.json/Business' with Property 'BusinessTypeId'
            ///Property <see cref="BusinessId"/> from Vocab 'Business.cdm.json/Business' with Property 'ParentBusinessId'
            ///Property <see cref="BusinessId"/> from Vocab 'BusinessFacility.cdm.json/BusinessFacility' with Property 'BusinessId'
            ///Property <see cref="BusinessId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'BusinessId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BusinessFacility.cdm.json/BusinessFacility' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessFacilityId"/> from Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'FacilityId'
            ///Property <see cref="BusinessFacilityId"/> from Vocab 'ServiceOrder.cdm.json/ServiceOrder' with Property 'BusinessFacilityId'
            ///Property <see cref="BusinessFacilityId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'BusinessFacilityId'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'Deal.cdm.json/Deal' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'DealerPlate.cdm.json/DealerPlate' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'Device.cdm.json/Device' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'Fleet.cdm.json/Fleet' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'ServiceAppointment.cdm.json/ServiceAppointment' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'ServiceOrder.cdm.json/ServiceOrder' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'ServiceOrderJobDetail.cdm.json/ServiceOrderJobDetail' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'BusinessOperationId'
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
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'Warranty.cdm.json/Warranty' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'WarrantyLimit.cdm.json/WarrantyLimit' with Property 'OwningBusinessUnit'
            ///Property <see cref="BusinessUnitId"/> from Vocab 'WarrantyType.cdm.json/WarrantyType' with Property 'OwningBusinessUnit'
            #endregion
        }

        public VocabularyKey BusinessId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
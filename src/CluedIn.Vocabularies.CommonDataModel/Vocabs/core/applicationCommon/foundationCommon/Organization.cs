using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class OrganizationVocabulary : SimpleVocabulary
    {
        public OrganizationVocabulary()
        {
            VocabularyName = "Organization";
            KeyPrefix = "commonDataModel.organization.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Organization;

            AddGroup("Organization Details for FoundationCommon", group =>
            {
			    SchedulingEngine = group.Add(new VocabularyKey(nameof(SchedulingEngine), "Scheduling engine for Appointments and Service Activities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="BaseCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="OrganizationId"/> from Vocab 'PriceList.cdm.json/PriceList' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/Article.cdm.json/Article' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/ArticleTemplate.cdm.json/ArticleTemplate' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/ConnectionRole.cdm.json/ConnectionRole' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/GoalMetric.cdm.json/GoalMetric' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/Position.cdm.json/Position' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/Queue.cdm.json/Queue' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/QueueItem.cdm.json/QueueItem' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/Territory.cdm.json/Territory' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/education/higherEducation/GrantApplicationBusinessProcessFlow.cdm.json/GrantApplicationBusinessProcessFlow' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/education/higherEducation/InternshipApplicationFlow.cdm.json/InternshipApplicationFlow' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/education/higherEducation/ScholarshipApplicationBusinessProcessFlow.cdm.json/ScholarshipApplicationBusinessProcessFlow' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionBodySite.cdm.json/ActivityDefinitionBodySite' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionContact.cdm.json/ActivityDefinitionContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionContributor.cdm.json/ActivityDefinitionContributor' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionContributorContact.cdm.json/ActivityDefinitionContributorContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionDosage.cdm.json/ActivityDefinitionDosage' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionDynamicValue.cdm.json/ActivityDefinitionDynamicValue' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionJurisdiction.cdm.json/ActivityDefinitionJurisdiction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionLibrary.cdm.json/ActivityDefinitionLibrary' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionParticipant.cdm.json/ActivityDefinitionParticipant' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionRelatedArtifact.cdm.json/ActivityDefinitionRelatedArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionTopic.cdm.json/ActivityDefinitionTopic' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionUseContext.cdm.json/ActivityDefinitionUseContext' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/CodeableConcept.cdm.json/CodeableConcept' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirement.cdm.json/DataRequirement' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementCodeFilter.cdm.json/DataRequirementCodeFilter' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementCodeFilterValueCode.cdm.json/DataRequirementCodeFilterValueCode' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataReqCodeFilterValueCodeableConcept.cdm.json/DataReqCodeFilterValueCodeableConcept' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementCodeFilterValueCoding.cdm.json/DataRequirementCodeFilterValueCoding' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementDateFilter.cdm.json/DataRequirementDateFilter' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementMustSupport.cdm.json/DataRequirementMustSupport' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementProfile.cdm.json/DataRequirementProfile' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DeviceComponent.cdm.json/DeviceComponent' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DeviceComponentOperationalStatus.cdm.json/DeviceComponentOperationalStatus' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/DeviceComponentProductionSpecification.cdm.json/DeviceComponentProductionSpecification' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/Endpoint.cdm.json/Endpoint' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointContact.cdm.json/EndpointContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointHeader.cdm.json/EndpointHeader' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointPayloadMimeType.cdm.json/EndpointPayloadMimeType' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointPayloadType.cdm.json/EndpointPayloadType' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareService.cdm.json/HealthcareService' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceAvailableTime.cdm.json/HealthcareServiceAvailableTime' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceCategory.cdm.json/HealthcareServiceCategory' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceCharacteristic.cdm.json/HealthcareServiceCharacteristic' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceCoverageArea.cdm.json/HealthcareServiceCoverageArea' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceEndpoint.cdm.json/HealthcareServiceEndpoint' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceLocation.cdm.json/HealthcareServiceLocation' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceProgramName.cdm.json/HealthcareServiceProgramName' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceProvision.cdm.json/HealthcareServiceProvision' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceReferralMethod.cdm.json/HealthcareServiceReferralMethod' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceSpecialty.cdm.json/HealthcareServiceSpecialty' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceTelecom.cdm.json/HealthcareServiceTelecom' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinition.cdm.json/ActivityDefinition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/Location.cdm.json/Location' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/LocationTelecom.cdm.json/LocationTelecom' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinition.cdm.json/PlanDefinition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionAction.cdm.json/PlanDefinitionActionAction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionArtifact.cdm.json/PlanDefinitionActionArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionCode.cdm.json/PlanDefinitionActionCode' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionCondition.cdm.json/PlanDefinitionActionCondition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionDynamicValue.cdm.json/PlanDefinitionActionDynamicValue' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionGoal.cdm.json/PlanDefinitionActionGoal' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionInput.cdm.json/PlanDefinitionActionInput' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionOutput.cdm.json/PlanDefinitionActionOutput' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionReason.cdm.json/PlanDefinitionActionReason' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionRelatedAction.cdm.json/PlanDefinitionActionRelatedAction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionTriggerDefinition.cdm.json/PlanDefinitionActionTriggerDefinition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionArtifact.cdm.json/PlanDefinitionArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionContributor.cdm.json/PlanDefinitionContributor' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionContributorContact.cdm.json/PlanDefinitionContributorContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoal.cdm.json/PlanDefinitionGoal' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoalAddresses.cdm.json/PlanDefinitionGoalAddresses' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoalArtifact.cdm.json/PlanDefinitionGoalArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoalTarget.cdm.json/PlanDefinitionGoalTarget' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionJurisdiction.cdm.json/PlanDefinitionJurisdiction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionLibrary.cdm.json/PlanDefinitionLibrary' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionParticipant.cdm.json/PlanDefinitionParticipant' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionTopic.cdm.json/PlanDefinitionTopic' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionUseContext.cdm.json/PlanDefinitionUseContext' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/Substance.cdm.json/Substance' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/SubstanceCategory.cdm.json/SubstanceCategory' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/SubstanceIngredient.cdm.json/SubstanceIngredient' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/SubstanceInstance.cdm.json/SubstanceInstance' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/Timing.cdm.json/Timing' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingDayOfWeek.cdm.json/TimingDayOfWeek' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingEvent.cdm.json/TimingEvent' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingTimeOfDay.cdm.json/TimingTimeOfDay' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingWhen.cdm.json/TimingWhen' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Product.cdm.json/Product' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'ProductAssociation.cdm.json/ProductAssociation' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'ProductRelationship.cdm.json/ProductRelationship' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Property.cdm.json/Property' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'PropertyAssociation.cdm.json/PropertyAssociation' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'PropertyOptionSetItem.cdm.json/PropertyOptionSetItem' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'UnitGroup.cdm.json/UnitGroup' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/automotive/AutoLeadToOpportunitySalesProcess.cdm.json/AutoLeadToOpportunitySalesProcess' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/BusinessCheckingAccount.cdm.json/BusinessCheckingAccount' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/CertificateOfDeposit.cdm.json/CertificateOfDeposit' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/CommercialDeposit.cdm.json/CommercialDeposit' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/CommercialLoan.cdm.json/CommercialLoan' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Company360.cdm.json/Company360' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/CompanyOnboarding.cdm.json/CompanyOnboarding' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/ContactOnboardingFromProspect.cdm.json/ContactOnboardingFromProspect' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Customer360Person.cdm.json/Customer360Person' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/CustomerJourney.cdm.json/CustomerJourney' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/MortgageApplication.cdm.json/MortgageApplication' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/sales/Competitor.cdm.json/Competitor' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/sales/DiscountList.cdm.json/DiscountList' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/sales/SalesLiterature.cdm.json/SalesLiterature' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/FacilityEquipment.cdm.json/FacilityEquipment' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/Resource.cdm.json/Resource' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/ResourceSpecification.cdm.json/ResourceSpecification' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/SchedulingGroup.cdm.json/SchedulingGroup' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/Service.cdm.json/Service' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/Site.cdm.json/Site' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/service/User.cdm.json/User' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/solutions/portals/Article.cdm.json/Article' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/solutions/portals/Badge.cdm.json/Badge' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/solutions/portals/BadgeType.cdm.json/BadgeType' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/solutions/portals/ExternalIdentity.cdm.json/ExternalIdentity' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'crmCommon/solutions/portals/WebTemplate.cdm.json/WebTemplate' with Property 'OrganizationId'
            #endregion
        }

        public VocabularyKey SchedulingEngine { get; private set; }
    }
}
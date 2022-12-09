using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SLAVocabulary : SimpleVocabulary
    {
        public SLAVocabulary()
        {
            VocabularyName = "SLA";
            KeyPrefix = "commonDataModel.sla";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SLA;

            AddGroup("SLA Details for ApplicationCommon", group =>
            {
			    SLAId = group.Add(new VocabularyKey(nameof(SLAId), "SLA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BusinessHoursId = group.Add(new VocabularyKey(nameof(BusinessHoursId), "Business Hours", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Object Type Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChangedAttributeList = group.Add(new VocabularyKey(nameof(ChangedAttributeList), "ChangedAttributeList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicableFrom = group.Add(new VocabularyKey(nameof(ApplicableFrom), "Applicable From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolutionId = group.Add(new VocabularyKey(nameof(SolutionId), "Solution", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ComponentState = group.Add(new VocabularyKey(nameof(ComponentState), "Component State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverwriteTime = group.Add(new VocabularyKey(nameof(OverwriteTime), "Record Overwrite Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsManaged = group.Add(new VocabularyKey(nameof(IsManaged), "Is Managed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SLAIdUnique = group.Add(new VocabularyKey(nameof(SLAIdUnique), "Unique Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ApplicableFromPickList = group.Add(new VocabularyKey(nameof(ApplicableFromPickList), "Applicable From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), "Workflow ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowPauseResume = group.Add(new VocabularyKey(nameof(AllowPauseResume), "Allow Pause and Resume", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SLAType = group.Add(new VocabularyKey(nameof(SLAType), "SLA Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryEntityOTC = group.Add(new VocabularyKey(nameof(PrimaryEntityOTC), "Primary Entity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Regarding"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Regarding"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="Regarding"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Regarding"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Regarding"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Regarding"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SLAId"/> from Vocab 'Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Email.cdm.json/Email' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Email.cdm.json/Email' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="SLAId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'SLAItem.cdm.json/SLAItem' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Task.cdm.json/Task' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'Task.cdm.json/Task' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Opportunity.cdm.json/Opportunity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/financialServices/banking/Opportunity.cdm.json/Opportunity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/AppointmentEMR.cdm.json/AppointmentEMR' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/AppointmentEMR.cdm.json/AppointmentEMR' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Task.cdm.json/Task' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Task.cdm.json/Task' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Opportunity.cdm.json/Opportunity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Opportunity.cdm.json/Opportunity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Opportunity.cdm.json/Opportunity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitIati/Opportunity.cdm.json/Opportunity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/Lead.cdm.json/Lead' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/Lead.cdm.json/Lead' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Invoice.cdm.json/Invoice' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Invoice.cdm.json/Invoice' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Opportunity.cdm.json/Opportunity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Opportunity.cdm.json/Opportunity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Order.cdm.json/Order' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Order.cdm.json/Order' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectServiceApproval.cdm.json/ProjectServiceApproval' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectServiceApproval.cdm.json/ProjectServiceApproval' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Quote.cdm.json/Quote' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Quote.cdm.json/Quote' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/scheduling/BookingAlert.cdm.json/BookingAlert' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/scheduling/BookingAlert.cdm.json/BookingAlert' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/Task.cdm.json/Task' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/service/Task.cdm.json/Task' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Appointment.cdm.json/Appointment' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Appointment.cdm.json/Appointment' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/PhoneCall.cdm.json/PhoneCall' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/PhoneCall.cdm.json/PhoneCall' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Task.cdm.json/Task' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Task.cdm.json/Task' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/eventManagement/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/eventManagement/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Contact.cdm.json/Contact' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Contact.cdm.json/Contact' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'SLAInvokedId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'SLAId'
            ///Property <see cref="SLAId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'SLAInvokedId'
            #endregion
        }

        public VocabularyKey AllowPauseResume { get; private set; }
        public VocabularyKey ApplicableFrom { get; private set; }
        public VocabularyKey ApplicableFromPickList { get; private set; }
        public VocabularyKey BusinessHoursId { get; private set; }
        public VocabularyKey ChangedAttributeList { get; private set; }
        public VocabularyKey ComponentState { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey IsManaged { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey OverwriteTime { get; private set; }
        public VocabularyKey PrimaryEntityOTC { get; private set; }
        public VocabularyKey SLAId { get; private set; }
        public VocabularyKey SLAIdUnique { get; private set; }
        public VocabularyKey SLAType { get; private set; }
        public VocabularyKey SolutionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
    }
}
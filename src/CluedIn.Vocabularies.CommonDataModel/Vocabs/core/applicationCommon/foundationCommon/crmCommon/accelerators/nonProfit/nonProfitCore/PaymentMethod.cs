using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PaymentMethodVocabulary : SimpleVocabulary
    {
        public PaymentMethodVocabulary()
        {
            VocabularyName = "Payment Method";
            KeyPrefix = "commonDataModel.paymentmethod";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PaymentMethod;

            AddGroup("PaymentMethod Details for NonProfitCore", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatus = group.Add(new VocabularyKey(nameof(LastAuthenticationStatus), "Last Authentication Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatusDate = group.Add(new VocabularyKey(nameof(LastAuthenticationStatusDate), "Last Authentication Status Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatusDetail = group.Add(new VocabularyKey(nameof(LastAuthenticationStatusDetail), "Last Authentication Status Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastAuthenticationStatusTechnicalDetail = group.Add(new VocabularyKey(nameof(LastAuthenticationStatusTechnicalDetail), "Last Authentication Status Technical Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentMethodId = group.Add(new VocabularyKey(nameof(PaymentMethodId), "Payment Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("PaymentMethod Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="PayorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            ///Property <see cref="PaymentScheduleId"/> to Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleId'
            ///Property <see cref="TransactionId"/> to Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PaymentMethodId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionPaymentMethodId'
            ///Property <see cref="PaymentMethodId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Transaction.cdm.json/Transaction' with Property 'TransactionPaymentMethodId'
            #endregion
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey LastAuthenticationStatus { get; private set; }
        public VocabularyKey LastAuthenticationStatusDate { get; private set; }
        public VocabularyKey LastAuthenticationStatusDetail { get; private set; }
        public VocabularyKey LastAuthenticationStatusTechnicalDetail { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PaymentMethodId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}
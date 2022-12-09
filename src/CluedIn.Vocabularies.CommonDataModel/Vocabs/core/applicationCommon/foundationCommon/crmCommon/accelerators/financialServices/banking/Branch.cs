using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class BranchVocabulary : SimpleVocabulary
    {
        public BranchVocabulary()
        {
            VocabularyName = "Branch";
            KeyPrefix = "commonDataModel.branch";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Branch;

            AddGroup("Branch Details for Banking", group =>
            {
			    AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), "Address Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BranchCode = group.Add(new VocabularyKey(nameof(BranchCode), "Branch Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BranchId = group.Add(new VocabularyKey(nameof(BranchId), "Branch", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BranchName = group.Add(new VocabularyKey(nameof(BranchName), "Branch Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TelephoneNo = group.Add(new VocabularyKey(nameof(TelephoneNo), "Telephone No.", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    ZipCodes = group.Add(new VocabularyKey(nameof(ZipCodes), "Zip Codes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="BankId"/> to Vocab 'Bank.cdm.json/Bank' with Property 'BankId'
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
            ///Property <see cref="BranchManagerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BranchId"/> from Vocab 'Account.cdm.json/Account' with Property 'EnrollmentBranchId'
            ///Property <see cref="BranchId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'EnrollmentBranchId'
            ///Property <see cref="BranchId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'PreferredBranchId'
            ///Property <see cref="BranchId"/> from Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'BranchId'
            #endregion
        }

        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey BranchCode { get; private set; }
        public VocabularyKey BranchId { get; private set; }
        public VocabularyKey BranchName { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TelephoneNo { get; private set; }
        public VocabularyKey ZipCodes { get; private set; }
    }
}
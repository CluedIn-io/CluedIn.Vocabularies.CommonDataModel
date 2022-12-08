using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class CustomerRelationshipVocabulary : SimpleVocabulary
    {
        public CustomerRelationshipVocabulary()
        {
            VocabularyName = "Customer Relationship";
            KeyPrefix = "commonDataModel.customerrelationship.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CustomerRelationship;

            AddGroup("CustomerRelationship Details for ApplicationCommon", group =>
            {
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerRoleId = group.Add(new VocabularyKey(nameof(CustomerRoleId), "Role 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerRelationshipId = group.Add(new VocabularyKey(nameof(CustomerRelationshipId), "Customer Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartnerRoleId = group.Add(new VocabularyKey(nameof(PartnerRoleId), "Role 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerRoleDescription = group.Add(new VocabularyKey(nameof(CustomerRoleDescription), "Description 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartnerRoleDescription = group.Add(new VocabularyKey(nameof(PartnerRoleDescription), "Description 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="PartnerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="PartnerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ConverseRelationshipId"/> to Vocab 'CustomerRelationship.cdm.json/CustomerRelationship' with Property 'CustomerRelationshipId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CustomerRelationshipId"/> from Vocab 'CustomerRelationship.cdm.json/CustomerRelationship' with Property 'ConverseRelationshipId'
            #endregion
        }

        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey CustomerRoleId { get; private set; }
        public VocabularyKey CustomerRelationshipId { get; private set; }
        public VocabularyKey PartnerRoleId { get; private set; }
        public VocabularyKey CustomerRoleDescription { get; private set; }
        public VocabularyKey PartnerRoleDescription { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
    }
}
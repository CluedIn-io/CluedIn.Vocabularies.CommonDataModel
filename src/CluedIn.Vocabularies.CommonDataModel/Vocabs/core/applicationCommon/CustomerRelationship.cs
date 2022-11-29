using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class CustomerRelationshipVocabulary : SimpleVocabulary
    {
        public CustomerRelationshipVocabulary()
        {
            VocabularyName = "Customer Relationship";
            KeyPrefix = "commonDataModel.customerrelationship.applicationcommon";
            KeySeparator = ".";
            Grouping = "/CustomerRelationship";

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
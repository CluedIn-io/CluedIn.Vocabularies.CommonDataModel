using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class ResourceExpansionVocabulary : SimpleVocabulary
    {
        public ResourceExpansionVocabulary()
        {
            VocabularyName = "Resource Expansion";
            KeyPrefix = "commonDataModel.resourceexpansion.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ResourceExpansion;

            AddGroup("ResourceExpansion Details for Service", group =>
            {
			    ResourceGroupExpansionId = group.Add(new VocabularyKey(nameof(ResourceGroupExpansionId), "Resource Expansion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemId = group.Add(new VocabularyKey(nameof(ItemId), "Item", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    MethodCode = group.Add(new VocabularyKey(nameof(MethodCode), "Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectId = group.Add(new VocabularyKey(nameof(ObjectId), "Object", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ResourceGroupExpansionId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey MethodCode { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ObjectId { get; private set; }
    }
}
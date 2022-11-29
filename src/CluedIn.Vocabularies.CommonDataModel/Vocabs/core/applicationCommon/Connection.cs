using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class ConnectionVocabulary : SimpleVocabulary
    {
        public ConnectionVocabulary()
        {
            VocabularyName = "Connection";
            KeyPrefix = "commonDataModel.connection.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Connection";

            AddGroup("Connection Details for ApplicationCommon", group =>
            {
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConnectionId = group.Add(new VocabularyKey(nameof(ConnectionId), "Connection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveStart = group.Add(new VocabularyKey(nameof(EffectiveStart), "Starting", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsMaster = group.Add(new VocabularyKey(nameof(IsMaster), "Is Master", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveEnd = group.Add(new VocabularyKey(nameof(EffectiveEnd), "Ending", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Record2ObjectTypeCode = group.Add(new VocabularyKey(nameof(Record2ObjectTypeCode), "Type (To)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Record1ObjectTypeCode = group.Add(new VocabularyKey(nameof(Record1ObjectTypeCode), "Type (From)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Connection Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ConnectionId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey EffectiveStart { get; private set; }
        public VocabularyKey IsMaster { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey EffectiveEnd { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Record2ObjectTypeCode { get; private set; }
        public VocabularyKey Record1ObjectTypeCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
    }
}
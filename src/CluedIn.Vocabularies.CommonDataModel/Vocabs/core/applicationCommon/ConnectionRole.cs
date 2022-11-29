using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class ConnectionRoleVocabulary : SimpleVocabulary
    {
        public ConnectionRoleVocabulary()
        {
            VocabularyName = "Connection Role";
            KeyPrefix = "commonDataModel.connectionrole.applicationcommon";
            KeySeparator = ".";
            Grouping = "/ConnectionRole";

            AddGroup("ConnectionRole Details for ApplicationCommon", group =>
            {
			    ConnectionRoleId = group.Add(new VocabularyKey(nameof(ConnectionRoleId), "Connection Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Category = group.Add(new VocabularyKey(nameof(Category), "Connection Role Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolutionId = group.Add(new VocabularyKey(nameof(SolutionId), "Solution", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ComponentState = group.Add(new VocabularyKey(nameof(ComponentState), "Component State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverwriteTime = group.Add(new VocabularyKey(nameof(OverwriteTime), "Overwritten On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConnectionRoleIdUnique = group.Add(new VocabularyKey(nameof(ConnectionRoleIdUnique), "Unique ID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IsManaged = group.Add(new VocabularyKey(nameof(IsManaged), "State", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsCustomizable = group.Add(new VocabularyKey(nameof(IsCustomizable), "Customizable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IntroducedVersion = group.Add(new VocabularyKey(nameof(IntroducedVersion), "Introduced Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ConnectionRoleId { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey SolutionId { get; private set; }
        public VocabularyKey ComponentState { get; private set; }
        public VocabularyKey OverwriteTime { get; private set; }
        public VocabularyKey ConnectionRoleIdUnique { get; private set; }
        public VocabularyKey IsManaged { get; private set; }
        public VocabularyKey IsCustomizable { get; private set; }
        public VocabularyKey IntroducedVersion { get; private set; }
    }
}
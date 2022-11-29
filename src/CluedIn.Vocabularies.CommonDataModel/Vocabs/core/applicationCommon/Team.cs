using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class TeamVocabulary : SimpleVocabulary
    {
        public TeamVocabulary()
        {
            VocabularyName = "Team";
            KeyPrefix = "commonDataModel.team.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Team";

            AddGroup("Team Details for ApplicationCommon", group =>
            {
			    TeamId = group.Add(new VocabularyKey(nameof(TeamId), "Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Team Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    YomiName = group.Add(new VocabularyKey(nameof(YomiName), "Yomi Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TeamType = group.Add(new VocabularyKey(nameof(TeamType), "Team Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeamTemplateId = group.Add(new VocabularyKey(nameof(TeamTemplateId), "Team Template Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SystemManaged = group.Add(new VocabularyKey(nameof(SystemManaged), "Is System Managed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey TeamId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey YomiName { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey TeamType { get; private set; }
        public VocabularyKey TeamTemplateId { get; private set; }
        public VocabularyKey SystemManaged { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
    }
}
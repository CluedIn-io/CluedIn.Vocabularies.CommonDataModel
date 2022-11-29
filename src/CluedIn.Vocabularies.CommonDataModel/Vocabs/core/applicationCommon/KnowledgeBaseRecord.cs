using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class KnowledgeBaseRecordVocabulary : SimpleVocabulary
    {
        public KnowledgeBaseRecordVocabulary()
        {
            VocabularyName = "Knowledge Base Record";
            KeyPrefix = "commonDataModel.knowledgebaserecord.applicationcommon";
            KeySeparator = ".";
            Grouping = "/KnowledgeBaseRecord";

            AddGroup("KnowledgeBaseRecord Details for ApplicationCommon", group =>
            {
			    KnowledgeBaseRecordId = group.Add(new VocabularyKey(nameof(KnowledgeBaseRecordId), "ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "KB Record Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrivateUrl = group.Add(new VocabularyKey(nameof(PrivateUrl), "Private URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PublicUrl = group.Add(new VocabularyKey(nameof(PublicUrl), "Public URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    UniqueId = group.Add(new VocabularyKey(nameof(UniqueId), "Unique ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey KnowledgeBaseRecordId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey PrivateUrl { get; private set; }
        public VocabularyKey PublicUrl { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey UniqueId { get; private set; }
    }
}
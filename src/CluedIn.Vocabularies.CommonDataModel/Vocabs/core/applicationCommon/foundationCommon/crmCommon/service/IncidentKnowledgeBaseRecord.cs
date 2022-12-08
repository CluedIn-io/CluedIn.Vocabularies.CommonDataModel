using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class IncidentKnowledgeBaseRecordVocabulary : SimpleVocabulary
    {
        public IncidentKnowledgeBaseRecordVocabulary()
        {
            VocabularyName = "Incident Knowledge Base Record";
            KeyPrefix = "commonDataModel.incidentknowledgebaserecord.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.IncidentKnowledgeBaseRecord;

            AddGroup("IncidentKnowledgeBaseRecord Details for Service", group =>
            {
			    IncidentKnowledgeBaseRecordId = group.Add(new VocabularyKey(nameof(IncidentKnowledgeBaseRecordId), "Unique identifier of the knowledgebase records for the incident.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="IncidentId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="KnowledgeBaseRecordId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey IncidentKnowledgeBaseRecordId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}
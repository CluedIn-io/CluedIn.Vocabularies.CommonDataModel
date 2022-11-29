using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class ChildIncidentCountVocabulary : SimpleVocabulary
    {
        public ChildIncidentCountVocabulary()
        {
            VocabularyName = "Child Incident Count";
            KeyPrefix = "commonDataModel.childincidentcount.service";
            KeySeparator = ".";
            Grouping = "/ChildIncidentCount";

            AddGroup("ChildIncidentCount Details for Service", group =>
            {
			    ChildIncidentCountId = group.Add(new VocabularyKey(nameof(ChildIncidentCountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ParentCaseId = group.Add(new VocabularyKey(nameof(ParentCaseId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    NumberOfChildIncidents = group.Add(new VocabularyKey(nameof(NumberOfChildIncidents), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ChildIncidentCountId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ParentCaseId { get; private set; }
        public VocabularyKey NumberOfChildIncidents { get; private set; }
    }
}
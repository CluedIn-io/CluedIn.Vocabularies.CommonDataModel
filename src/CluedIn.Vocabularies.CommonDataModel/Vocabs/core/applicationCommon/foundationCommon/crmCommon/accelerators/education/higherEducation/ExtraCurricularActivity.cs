using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class ExtraCurricularActivityVocabulary : SimpleVocabulary
    {
        public ExtraCurricularActivityVocabulary()
        {
            VocabularyName = "Extra Curricular Activity";
            KeyPrefix = "commonDataModel.extracurricularactivity.highereducation";
            KeySeparator = ".";
            Grouping = "/ExtraCurricularActivity";

            AddGroup("ExtraCurricularActivity Details for HigherEducation", group =>
            {
			    ExtracurricularActivitiesId = group.Add(new VocabularyKey(nameof(ExtracurricularActivitiesId), "Extra Curricular Activity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Extra Curricular Activity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateofOrganizationFormed = group.Add(new VocabularyKey(nameof(DateofOrganizationFormed), "Date of Organization Formed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GeneralEmail = group.Add(new VocabularyKey(nameof(GeneralEmail), "General Email", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    OrganizationMissionStatement = group.Add(new VocabularyKey(nameof(OrganizationMissionStatement), "Organization Mission Statement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryPurpose = group.Add(new VocabularyKey(nameof(PrimaryPurpose), "Primary Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Website = group.Add(new VocabularyKey(nameof(Website), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExtracurricularActivitiesId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey DateofOrganizationFormed { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey GeneralEmail { get; private set; }
        public VocabularyKey OrganizationMissionStatement { get; private set; }
        public VocabularyKey PrimaryPurpose { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}
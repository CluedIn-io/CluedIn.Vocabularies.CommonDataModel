using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CareTeamVocabulary : SimpleVocabulary
    {
        public CareTeamVocabulary()
        {
            VocabularyName = "Care Team";
            KeyPrefix = "commonDataModel.careteam.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CareTeam";

            AddGroup("CareTeam Details for ElectronicMedicalRecords", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CareTeamId = group.Add(new VocabularyKey(nameof(CareTeamId), "Care Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CareTeamNumber = group.Add(new VocabularyKey(nameof(CareTeamNumber), "Care Team Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CareTeamStatus = group.Add(new VocabularyKey(nameof(CareTeamStatus), "Care Team Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), "Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), "Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey CareTeamId { get; private set; }
        public VocabularyKey CareTeamNumber { get; private set; }
        public VocabularyKey CareTeamStatus { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
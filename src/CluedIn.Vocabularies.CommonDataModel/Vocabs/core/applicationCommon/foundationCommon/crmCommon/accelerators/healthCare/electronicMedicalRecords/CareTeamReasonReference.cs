using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CareTeamReasonReferenceVocabulary : SimpleVocabulary
    {
        public CareTeamReasonReferenceVocabulary()
        {
            VocabularyName = "Care Team Reason Reference";
            KeyPrefix = "commonDataModel.careteamreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CareTeamReasonReference";

            AddGroup("CareTeamReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    CareTeamReasonReferenceId = group.Add(new VocabularyKey(nameof(CareTeamReasonReferenceId), "Care Team Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CareTeamReasonReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
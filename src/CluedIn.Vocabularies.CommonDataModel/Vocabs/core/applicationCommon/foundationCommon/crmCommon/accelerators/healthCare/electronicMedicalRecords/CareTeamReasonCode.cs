using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CareTeamReasonCodeVocabulary : SimpleVocabulary
    {
        public CareTeamReasonCodeVocabulary()
        {
            VocabularyName = "Care Team Reason Code";
            KeyPrefix = "commonDataModel.careteamreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CareTeamReasonCode";

            AddGroup("CareTeamReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    CareTeamReasonCodeId = group.Add(new VocabularyKey(nameof(CareTeamReasonCodeId), "Care Team Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CareTeamReasonCodeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class FamilyMemberHistoryReasonVocabulary : SimpleVocabulary
    {
        public FamilyMemberHistoryReasonVocabulary()
        {
            VocabularyName = "Family Member History Reason";
            KeyPrefix = "commonDataModel.familymemberhistoryreason.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/FamilyMemberHistoryReason";

            AddGroup("FamilyMemberHistoryReason Details for ElectronicMedicalRecords", group =>
            {
			    FamilyMemberHistoryReasonId = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryReasonId), "Family Member History Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonCodeText = group.Add(new VocabularyKey(nameof(ReasonCodeText), "Reason Code Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonCodeType = group.Add(new VocabularyKey(nameof(ReasonCodeType), "Reason Code Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FamilyMemberHistoryReasonId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonCodeText { get; private set; }
        public VocabularyKey ReasonCodeType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
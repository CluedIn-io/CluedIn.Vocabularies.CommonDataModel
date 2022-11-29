using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class FamilyMemberHistoryReasonReferenceVocabulary : SimpleVocabulary
    {
        public FamilyMemberHistoryReasonReferenceVocabulary()
        {
            VocabularyName = "Family Member History Reason Reference";
            KeyPrefix = "commonDataModel.familymemberhistoryreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/FamilyMemberHistoryReasonReference";

            AddGroup("FamilyMemberHistoryReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    FamilyMemberHistoryReasonReferenceId = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryReasonReferenceId), "Family Member History Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReferenceType = group.Add(new VocabularyKey(nameof(ReasonReferenceType), "Reason Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FamilyMemberHistoryReasonReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReferenceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
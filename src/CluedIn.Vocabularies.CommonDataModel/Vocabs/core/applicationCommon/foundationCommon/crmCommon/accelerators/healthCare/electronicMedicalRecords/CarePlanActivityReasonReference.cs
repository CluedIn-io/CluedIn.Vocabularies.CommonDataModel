using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityReasonReferenceVocabulary : SimpleVocabulary
    {
        public CarePlanActivityReasonReferenceVocabulary()
        {
            VocabularyName = "Care Plan Activity Reason Reference";
            KeyPrefix = "commonDataModel.careplanactivityreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivityReasonReference";

            AddGroup("CarePlanActivityReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanActivityReasonReferenceId = group.Add(new VocabularyKey(nameof(CarePlanActivityReasonReferenceId), "Care Plan Activity Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanActivityReasonReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanSupportInfoVocabulary : SimpleVocabulary
    {
        public CarePlanSupportInfoVocabulary()
        {
            VocabularyName = "Care Plan Support Info";
            KeyPrefix = "commonDataModel.careplansupportinfo.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanSupportInfo";

            AddGroup("CarePlanSupportInfo Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanSupportInfoId = group.Add(new VocabularyKey(nameof(CarePlanSupportInfoId), "Care Plan Support Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInfo = group.Add(new VocabularyKey(nameof(SupportingInfo), "Supporting Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanSupportInfoId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SupportingInfo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
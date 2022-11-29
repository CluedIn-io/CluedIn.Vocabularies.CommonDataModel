using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestSupportingInfoVocabulary : SimpleVocabulary
    {
        public DeviceRequestSupportingInfoVocabulary()
        {
            VocabularyName = "Device Request Supporting Info";
            KeyPrefix = "commonDataModel.devicerequestsupportinginfo.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequestSupportingInfo";

            AddGroup("DeviceRequestSupportingInfo Details for ElectronicMedicalRecords", group =>
            {
			    DeviceRequestSupportingInfoId = group.Add(new VocabularyKey(nameof(DeviceRequestSupportingInfoId), "Device Request Supporting Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInfo = group.Add(new VocabularyKey(nameof(SupportingInfo), "Supporting Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceRequestSupportingInfoId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SupportingInfo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
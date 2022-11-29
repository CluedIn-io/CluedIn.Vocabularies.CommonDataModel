using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceWarrantyLimitVocabulary : SimpleVocabulary
    {
        public DeviceWarrantyLimitVocabulary()
        {
            VocabularyName = "Device Warranty Limit";
            KeyPrefix = "commonDataModel.devicewarrantylimit.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceWarrantyLimit";

            AddGroup("DeviceWarrantyLimit Details for Automotive", group =>
            {
			    DeviceWarrantyLimitId = group.Add(new VocabularyKey(nameof(DeviceWarrantyLimitId), "Device Warranty Limit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceWarrantyLimitId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
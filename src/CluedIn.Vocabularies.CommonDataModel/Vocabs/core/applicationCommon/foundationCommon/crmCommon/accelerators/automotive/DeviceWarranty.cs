using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceWarrantyVocabulary : SimpleVocabulary
    {
        public DeviceWarrantyVocabulary()
        {
            VocabularyName = "Device Warranty";
            KeyPrefix = "commonDataModel.devicewarranty.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceWarranty";

            AddGroup("DeviceWarranty Details for Automotive", group =>
            {
			    DeviceWarrantyId = group.Add(new VocabularyKey(nameof(DeviceWarrantyId), "Device Warranty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IssuedOn = group.Add(new VocabularyKey(nameof(IssuedOn), "Issued On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceWarrantyId { get; private set; }
        public VocabularyKey IssuedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class LeadDeviceSpecificationVocabulary : SimpleVocabulary
    {
        public LeadDeviceSpecificationVocabulary()
        {
            VocabularyName = "Lead Device Specification";
            KeyPrefix = "commonDataModel.leaddevicespecification.automotive";
            KeySeparator = ".";
            Grouping = "/LeadDeviceSpecification";

            AddGroup("LeadDeviceSpecification Details for Automotive", group =>
            {
			    LeadDeviceSpecificationId = group.Add(new VocabularyKey(nameof(LeadDeviceSpecificationId), "Lead Device Specification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LeadDeviceSpecificationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
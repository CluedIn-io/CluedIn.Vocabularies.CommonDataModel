using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceGenerationVocabulary : SimpleVocabulary
    {
        public DeviceGenerationVocabulary()
        {
            VocabularyName = "Device Generation";
            KeyPrefix = "commonDataModel.devicegeneration.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceGeneration";

            AddGroup("DeviceGeneration Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceGenerationId = group.Add(new VocabularyKey(nameof(DeviceGenerationId), "Device Generation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FromYear = group.Add(new VocabularyKey(nameof(FromYear), "From Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToYear = group.Add(new VocabularyKey(nameof(ToYear), "To Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceGenerationId { get; private set; }
        public VocabularyKey FromYear { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ToYear { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
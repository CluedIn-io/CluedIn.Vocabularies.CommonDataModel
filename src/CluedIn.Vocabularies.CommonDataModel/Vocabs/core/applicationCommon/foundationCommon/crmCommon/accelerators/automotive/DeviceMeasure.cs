using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceMeasureVocabulary : SimpleVocabulary
    {
        public DeviceMeasureVocabulary()
        {
            VocabularyName = "Device Measure";
            KeyPrefix = "commonDataModel.devicemeasure.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceMeasure";

            AddGroup("DeviceMeasure Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceMeasureId = group.Add(new VocabularyKey(nameof(DeviceMeasureId), "Device Measure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayNumberOfDecimals = group.Add(new VocabularyKey(nameof(DisplayNumberOfDecimals), "Display Number of Decimals", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceMeasureId { get; private set; }
        public VocabularyKey DisplayNumberOfDecimals { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
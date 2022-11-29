using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceComponentVocabulary : SimpleVocabulary
    {
        public DeviceComponentVocabulary()
        {
            VocabularyName = "Device Component";
            KeyPrefix = "commonDataModel.devicecomponent.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceComponent";

            AddGroup("DeviceComponent Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Behavior = group.Add(new VocabularyKey(nameof(Behavior), "Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceComponentId = group.Add(new VocabularyKey(nameof(DeviceComponentId), "Device Component", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ItemName = group.Add(new VocabularyKey(nameof(ItemName), "Item Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Behavior { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceComponentId { get; private set; }
        public VocabularyKey ItemName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
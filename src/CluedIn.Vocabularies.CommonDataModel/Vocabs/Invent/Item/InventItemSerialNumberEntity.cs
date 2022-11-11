using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventItemSerialNumberEntityVocabulary : SimpleVocabulary
    {
        public InventItemSerialNumberEntityVocabulary()
        {
            VocabularyName = "InventItemSerialNumberEntity";
            KeyPrefix = "commonDataModel.inventitemserialnumberentity";
            KeySeparator = ".";
            Grouping = "/InventItemSerialNumberEntity";

            AddGroup("InventItemSerialNumberEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManufacturingDate = group.Add(new VocabularyKey(nameof(ManufacturingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ManufacturingDate { get; private set; }


    }
}
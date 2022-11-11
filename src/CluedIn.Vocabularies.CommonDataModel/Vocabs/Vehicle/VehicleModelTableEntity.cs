using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VehicleModelTableEntityVocabulary : SimpleVocabulary
    {
        public VehicleModelTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model VehicleModelTableEntity";
            KeyPrefix = "commonDataModel.vehiclemodeltableentity";
            KeySeparator = ".";
            Grouping = "/VehicleModelTableEntity";

            AddGroup("Common Data Model VehicleModelTableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Model = group.Add(new VocabularyKey(nameof(Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Model { get; private set; }


    }
}
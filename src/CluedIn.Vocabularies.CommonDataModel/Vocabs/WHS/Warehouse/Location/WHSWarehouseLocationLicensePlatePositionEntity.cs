using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationLicensePlatePositionEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationLicensePlatePositionEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationLicensePlatePositionEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationlicenseplatepositionentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationLicensePlatePositionEntity";

            AddGroup("Common Data Model WHSWarehouseLocationLicensePlatePositionEntity Details", group =>
            {
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlatePosition = group.Add(new VocabularyKey(nameof(LicensePlatePosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey LicensePlatePosition { get; private set; }


    }
}
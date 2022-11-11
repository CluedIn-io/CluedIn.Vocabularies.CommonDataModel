using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetAcceleratedDepreciationGroupEntityVocabulary : SimpleVocabulary
    {
        public AssetAcceleratedDepreciationGroupEntityVocabulary()
        {
            VocabularyName = "AssetAcceleratedDepreciationGroupEntity";
            KeyPrefix = "commonDataModel.assetaccelerateddepreciationgroupentity";
            KeySeparator = ".";
            Grouping = "/AssetAcceleratedDepreciationGroupEntity";

            AddGroup("AssetAcceleratedDepreciationGroupEntity Details", group =>
            {
                EquipmentGroup = group.Add(new VocabularyKey(nameof(EquipmentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentType = group.Add(new VocabularyKey(nameof(EquipmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentTypeDivision = group.Add(new VocabularyKey(nameof(EquipmentTypeDivision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndustryAverageHoursPerDay = group.Add(new VocabularyKey(nameof(IndustryAverageHoursPerDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndustryAnnualWorkingDays = group.Add(new VocabularyKey(nameof(IndustryAnnualWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EquipmentGroup { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey EquipmentType { get; private set; }
        public VocabularyKey EquipmentTypeDivision { get; private set; }
        public VocabularyKey IndustryAverageHoursPerDay { get; private set; }
        public VocabularyKey IndustryAnnualWorkingDays { get; private set; }


    }
}
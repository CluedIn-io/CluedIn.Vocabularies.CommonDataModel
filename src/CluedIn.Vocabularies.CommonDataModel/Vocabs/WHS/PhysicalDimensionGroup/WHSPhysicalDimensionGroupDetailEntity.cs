using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSPhysicalDimensionGroupDetailEntityVocabulary : SimpleVocabulary
    {
        public WHSPhysicalDimensionGroupDetailEntityVocabulary()
        {
            VocabularyName = "WHSPhysicalDimensionGroupDetailEntity";
            KeyPrefix = "commonDataModel.whsphysicaldimensiongroupdetailentity";
            KeySeparator = ".";
            Grouping = "/WHSPhysicalDimensionGroupDetailEntity";

            AddGroup("WHSPhysicalDimensionGroupDetailEntity Details", group =>
            {
                PhysicalDepth = group.Add(new VocabularyKey(nameof(PhysicalDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalHeight = group.Add(new VocabularyKey(nameof(PhysicalHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalDimensionGroupId = group.Add(new VocabularyKey(nameof(PhysicalDimensionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalUnitSymbol = group.Add(new VocabularyKey(nameof(PhysicalUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWeight = group.Add(new VocabularyKey(nameof(PhysicalWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWidth = group.Add(new VocabularyKey(nameof(PhysicalWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PhysicalDepth { get; private set; }
        public VocabularyKey PhysicalHeight { get; private set; }
        public VocabularyKey PhysicalDimensionGroupId { get; private set; }
        public VocabularyKey PhysicalUnitSymbol { get; private set; }
        public VocabularyKey PhysicalWeight { get; private set; }
        public VocabularyKey PhysicalWidth { get; private set; }


    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSItemPhysicalDimensionDetailEntityVocabulary : SimpleVocabulary
    {
        public WHSItemPhysicalDimensionDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSItemPhysicalDimensionDetailEntity";
            KeyPrefix = "commonDataModel.whsitemphysicaldimensiondetailentity";
            KeySeparator = ".";
            Grouping = "/WHSItemPhysicalDimensionDetailEntity";

            AddGroup("Common Data Model WHSItemPhysicalDimensionDetailEntity Details", group =>
            {
                PhysicalDepth = group.Add(new VocabularyKey(nameof(PhysicalDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalHeight = group.Add(new VocabularyKey(nameof(PhysicalHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalUnitSymbol = group.Add(new VocabularyKey(nameof(PhysicalUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWeight = group.Add(new VocabularyKey(nameof(PhysicalWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWidth = group.Add(new VocabularyKey(nameof(PhysicalWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PhysicalDepth { get; private set; }
        public VocabularyKey PhysicalHeight { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey PhysicalUnitSymbol { get; private set; }
        public VocabularyKey PhysicalWeight { get; private set; }
        public VocabularyKey PhysicalWidth { get; private set; }


    }
}
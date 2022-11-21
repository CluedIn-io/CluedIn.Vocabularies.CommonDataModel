using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResPhysicalProductDimensionDetailsEntityVocabulary : SimpleVocabulary
    {
        public EcoResPhysicalProductDimensionDetailsEntityVocabulary()
        {
            VocabularyName = "Eco Res Physical Product Dimension Details Entity";
            KeyPrefix = "commonDataModel.ecoresphysicalproductdimensiondetailsentity";
            KeySeparator = ".";
            Grouping = "/EcoResPhysicalProductDimensionDetailsEntity";

            AddGroup("EcoResPhysicalProductDimensionDetailsEntity Details", group =>
            {
                Product = group.Add(new VocabularyKey(nameof(Product), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionType = group.Add(new VocabularyKey(nameof(DimensionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalUnitSymbol = group.Add(new VocabularyKey(nameof(PhysicalUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalDepth = group.Add(new VocabularyKey(nameof(PhysicalDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalHeight = group.Add(new VocabularyKey(nameof(PhysicalHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWeight = group.Add(new VocabularyKey(nameof(PhysicalWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWidth = group.Add(new VocabularyKey(nameof(PhysicalWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MassUnitSymbol = group.Add(new VocabularyKey(nameof(MassUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LengthUnitSymbol = group.Add(new VocabularyKey(nameof(LengthUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeUnitSymbol = group.Add(new VocabularyKey(nameof(VolumeUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Product { get; private set; }
        public VocabularyKey DimensionType { get; private set; }
        public VocabularyKey PhysicalUnitSymbol { get; private set; }
        public VocabularyKey PhysicalDepth { get; private set; }
        public VocabularyKey PhysicalHeight { get; private set; }
        public VocabularyKey PhysicalWeight { get; private set; }
        public VocabularyKey PhysicalWidth { get; private set; }
        public VocabularyKey MassUnitSymbol { get; private set; }
        public VocabularyKey LengthUnitSymbol { get; private set; }
        public VocabularyKey VolumeUnitSymbol { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
    }
}
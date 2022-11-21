using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSGenerallyAvailableProductFilterEntityVocabulary : SimpleVocabulary
    {
        public WHSGenerallyAvailableProductFilterEntityVocabulary()
        {
            VocabularyName = "WHS Generally Available Product Filter Entity";
            KeyPrefix = "commonDataModel.whsgenerallyavailableproductfilterentity";
            KeySeparator = ".";
            Grouping = "/WHSGenerallyAvailableProductFilterEntity";

            AddGroup("WHSGenerallyAvailableProductFilterEntity Details", group =>
            {
                FromDateTime = group.Add(new VocabularyKey(nameof(FromDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FilterModule = group.Add(new VocabularyKey(nameof(FilterModule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableId = group.Add(new VocabularyKey(nameof(ReferenceTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstProductFilterCode = group.Add(new VocabularyKey(nameof(FirstProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondProductFilterCode = group.Add(new VocabularyKey(nameof(SecondProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdProductFilterCode = group.Add(new VocabularyKey(nameof(ThirdProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthProductFilterCode = group.Add(new VocabularyKey(nameof(FourthProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FromDateTime { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey FilterModule { get; private set; }
        public VocabularyKey ReferenceTableId { get; private set; }
        public VocabularyKey FirstProductFilterCode { get; private set; }
        public VocabularyKey SecondProductFilterCode { get; private set; }
        public VocabularyKey ThirdProductFilterCode { get; private set; }
        public VocabularyKey FourthProductFilterCode { get; private set; }
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSProductFilterGroupDetailV2EntityVocabulary : SimpleVocabulary
    {
        public WHSProductFilterGroupDetailV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSProductFilterGroupDetailV2Entity";
            KeyPrefix = "commonDataModel.whsproductfiltergroupdetailv2entity";
            KeySeparator = ".";
            Grouping = "/WHSProductFilterGroupDetailV2Entity";

            AddGroup("Common Data Model WHSProductFilterGroupDetailV2Entity Details", group =>
            {
                FromDateTime = group.Add(new VocabularyKey(nameof(FromDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableId = group.Add(new VocabularyKey(nameof(ReferenceTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDateTime = group.Add(new VocabularyKey(nameof(ToDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfDaysAllowedToMixBatches = group.Add(new VocabularyKey(nameof(NumberOfDaysAllowedToMixBatches), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstProductFilterCode = group.Add(new VocabularyKey(nameof(FirstProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondProductFilterCode = group.Add(new VocabularyKey(nameof(SecondProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdProductFilterCode = group.Add(new VocabularyKey(nameof(ThirdProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FourthProductFilterCode = group.Add(new VocabularyKey(nameof(FourthProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstProductFilterGroupId = group.Add(new VocabularyKey(nameof(FirstProductFilterGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondProductFilterGroupId = group.Add(new VocabularyKey(nameof(SecondProductFilterGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FromDateTime { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ReferenceTableId { get; private set; }
        public VocabularyKey ToDateTime { get; private set; }
        public VocabularyKey NumberOfDaysAllowedToMixBatches { get; private set; }
        public VocabularyKey FirstProductFilterCode { get; private set; }
        public VocabularyKey SecondProductFilterCode { get; private set; }
        public VocabularyKey ThirdProductFilterCode { get; private set; }
        public VocabularyKey FourthProductFilterCode { get; private set; }
        public VocabularyKey FirstProductFilterGroupId { get; private set; }
        public VocabularyKey SecondProductFilterGroupId { get; private set; }


    }
}
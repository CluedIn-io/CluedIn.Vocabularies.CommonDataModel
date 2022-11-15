using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSSecondProductFilterCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSSecondProductFilterCodeEntityVocabulary()
        {
            VocabularyName = "WHS Second Product Filter Code Entity";
            KeyPrefix = "commonDataModel.whssecondproductfiltercodeentity";
            KeySeparator = ".";
            Grouping = "/WHSSecondProductFilterCodeEntity";

            AddGroup("WHSSecondProductFilterCodeEntity Details", group =>
            {
                ProductFilterDescription = group.Add(new VocabularyKey(nameof(ProductFilterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductFilterCode = group.Add(new VocabularyKey(nameof(ProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductFilterDescription { get; private set; }
        public VocabularyKey ProductFilterCode { get; private set; }
    }
}
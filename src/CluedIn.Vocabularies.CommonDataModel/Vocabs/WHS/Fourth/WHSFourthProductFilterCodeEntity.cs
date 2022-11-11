using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFourthProductFilterCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSFourthProductFilterCodeEntityVocabulary()
        {
            VocabularyName = "WHSFourthProductFilterCodeEntity";
            KeyPrefix = "commonDataModel.whsfourthproductfiltercodeentity";
            KeySeparator = ".";
            Grouping = "/WHSFourthProductFilterCodeEntity";

            AddGroup("WHSFourthProductFilterCodeEntity Details", group =>
            {
                ProductFilterDescription = group.Add(new VocabularyKey(nameof(ProductFilterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductFilterCode = group.Add(new VocabularyKey(nameof(ProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductFilterDescription { get; private set; }
        public VocabularyKey ProductFilterCode { get; private set; }


    }
}
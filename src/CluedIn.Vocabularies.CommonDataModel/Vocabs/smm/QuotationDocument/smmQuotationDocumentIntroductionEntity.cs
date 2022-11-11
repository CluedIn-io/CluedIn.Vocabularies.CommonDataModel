using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmQuotationDocumentIntroductionEntityVocabulary : SimpleVocabulary
    {
        public smmQuotationDocumentIntroductionEntityVocabulary()
        {
            VocabularyName = "smmQuotationDocumentIntroductionEntity";
            KeyPrefix = "commonDataModel.smmquotationdocumentintroductionentity";
            KeySeparator = ".";
            Grouping = "/smmQuotationDocumentIntroductionEntity";

            AddGroup("smmQuotationDocumentIntroductionEntity Details", group =>
            {
                IntroductionName = group.Add(new VocabularyKey(nameof(IntroductionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntroductoryParagraph = group.Add(new VocabularyKey(nameof(IntroductoryParagraph), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IntroductionName { get; private set; }
        public VocabularyKey IntroductoryParagraph { get; private set; }


    }
}
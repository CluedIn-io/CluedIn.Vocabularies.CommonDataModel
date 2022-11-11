using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmQuotationDocumentConclusionEntityVocabulary : SimpleVocabulary
    {
        public smmQuotationDocumentConclusionEntityVocabulary()
        {
            VocabularyName = "smmQuotationDocumentConclusionEntity";
            KeyPrefix = "commonDataModel.smmquotationdocumentconclusionentity";
            KeySeparator = ".";
            Grouping = "/smmQuotationDocumentConclusionEntity";

            AddGroup("smmQuotationDocumentConclusionEntity Details", group =>
            {
                ConclusionName = group.Add(new VocabularyKey(nameof(ConclusionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConcludingParagraph = group.Add(new VocabularyKey(nameof(ConcludingParagraph), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConclusionName { get; private set; }
        public VocabularyKey ConcludingParagraph { get; private set; }


    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationScoringMethodEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationScoringMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchRequestForQuotationScoringMethodEntity";
            KeyPrefix = "commonDataModel.purchrequestforquotationscoringmethodentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationScoringMethodEntity";

            AddGroup("Common Data Model PurchRequestForQuotationScoringMethodEntity Details", group =>
            {
                MethodName = group.Add(new VocabularyKey(nameof(MethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodDescription = group.Add(new VocabularyKey(nameof(MethodDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MethodName { get; private set; }
        public VocabularyKey MethodDescription { get; private set; }


    }
}
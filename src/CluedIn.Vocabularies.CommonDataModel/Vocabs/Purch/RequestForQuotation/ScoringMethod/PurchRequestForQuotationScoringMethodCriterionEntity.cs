using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationScoringMethodCriterionEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationScoringMethodCriterionEntityVocabulary()
        {
            VocabularyName = "Purch Request For Quotation Scoring Method Criterion Entity";
            KeyPrefix = "commonDataModel.purchrequestforquotationscoringmethodcriterionentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationScoringMethodCriterionEntity";

            AddGroup("PurchRequestForQuotationScoringMethodCriterionEntity Details", group =>
            {
                RFQScoringMethodRecId = group.Add(new VocabularyKey(nameof(RFQScoringMethodRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQScoringMethodName = group.Add(new VocabularyKey(nameof(RFQScoringMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriterionName = group.Add(new VocabularyKey(nameof(CriterionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriterionDescription = group.Add(new VocabularyKey(nameof(CriterionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPoints = group.Add(new VocabularyKey(nameof(MinimumPoints), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPoints = group.Add(new VocabularyKey(nameof(MaximumPoints), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RFQScoringMethodRecId { get; private set; }
        public VocabularyKey RFQScoringMethodName { get; private set; }
        public VocabularyKey CriterionName { get; private set; }
        public VocabularyKey CriterionDescription { get; private set; }
        public VocabularyKey MinimumPoints { get; private set; }
        public VocabularyKey MaximumPoints { get; private set; }
    }
}
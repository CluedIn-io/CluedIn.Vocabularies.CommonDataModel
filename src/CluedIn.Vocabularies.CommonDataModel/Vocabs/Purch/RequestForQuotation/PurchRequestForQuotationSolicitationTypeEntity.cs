using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationSolicitationTypeEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationSolicitationTypeEntityVocabulary()
        {
            VocabularyName = "Purch Request For Quotation Solicitation Type Entity";
            KeyPrefix = "commonDataModel.purchrequestforquotationsolicitationtypeentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationSolicitationTypeEntity";

            AddGroup("PurchRequestForQuotationSolicitationTypeEntity Details", group =>
            {
                DefaultScoringMethod = group.Add(new VocabularyKey(nameof(DefaultScoringMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQScoringMethodName = group.Add(new VocabularyKey(nameof(DefaultRFQScoringMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultScoringMethod { get; private set; }
        public VocabularyKey TypeName { get; private set; }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey DefaultRFQScoringMethodName { get; private set; }
    }
}
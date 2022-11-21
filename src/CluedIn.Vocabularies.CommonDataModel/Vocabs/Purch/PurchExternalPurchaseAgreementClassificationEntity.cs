using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchExternalPurchaseAgreementClassificationEntityVocabulary : SimpleVocabulary
    {
        public PurchExternalPurchaseAgreementClassificationEntityVocabulary()
        {
            VocabularyName = "Purch External Purchase Agreement Classification Entity";
            KeyPrefix = "commonDataModel.purchexternalpurchaseagreementclassificationentity";
            KeySeparator = ".";
            Grouping = "/PurchExternalPurchaseAgreementClassificationEntity";

            AddGroup("PurchExternalPurchaseAgreementClassificationEntity Details", group =>
            {
                ExternalAgreementClassificationName = group.Add(new VocabularyKey(nameof(ExternalAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementClassificationName = group.Add(new VocabularyKey(nameof(PurchaseAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalAgreementClassificationCodeId = group.Add(new VocabularyKey(nameof(ExternalAgreementClassificationCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExternalAgreementClassificationName { get; private set; }
        public VocabularyKey PurchaseAgreementClassificationName { get; private set; }
        public VocabularyKey ExternalAgreementClassificationCodeId { get; private set; }
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPriceSmartRoundingVersionRuleEntityVocabulary : SimpleVocabulary
    {
        public SalesPriceSmartRoundingVersionRuleEntityVocabulary()
        {
            VocabularyName = "SalesPriceSmartRoundingVersionRuleEntity";
            KeyPrefix = "commonDataModel.salespricesmartroundingversionruleentity";
            KeySeparator = ".";
            Grouping = "/SalesPriceSmartRoundingVersionRuleEntity";

            AddGroup("SalesPriceSmartRoundingVersionRuleEntity Details", group =>
            {
                SalesPriceSmartRoundingVersionId = group.Add(new VocabularyKey(nameof(SalesPriceSmartRoundingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingSyntax = group.Add(new VocabularyKey(nameof(RoundingSyntax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingDownLimitPoint = group.Add(new VocabularyKey(nameof(RoundingDownLimitPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingUpLimitPoint = group.Add(new VocabularyKey(nameof(RoundingUpLimitPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromUnitPrice = group.Add(new VocabularyKey(nameof(FromUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToUnitPrice = group.Add(new VocabularyKey(nameof(ToUnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingVersionRecId = group.Add(new VocabularyKey(nameof(RoundingVersionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesPriceSmartRoundingVersionId { get; private set; }
        public VocabularyKey RoundingSyntax { get; private set; }
        public VocabularyKey RoundingDownLimitPoint { get; private set; }
        public VocabularyKey RoundingUpLimitPoint { get; private set; }
        public VocabularyKey FromUnitPrice { get; private set; }
        public VocabularyKey ToUnitPrice { get; private set; }
        public VocabularyKey RoundingVersionRecId { get; private set; }


    }
}
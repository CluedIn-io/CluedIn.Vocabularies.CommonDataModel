using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxBenefitCodeTypeEntityVocabulary : SimpleVocabulary
    {
        public TaxBenefitCodeTypeEntityVocabulary()
        {
            VocabularyName = "Tax Benefit Code Type Entity";
            KeyPrefix = "commonDataModel.taxbenefitcodetypeentity";
            KeySeparator = ".";
            Grouping = "/TaxBenefitCodeTypeEntity";

            AddGroup("TaxBenefitCodeTypeEntity Details", group =>
            {
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }
    }
}
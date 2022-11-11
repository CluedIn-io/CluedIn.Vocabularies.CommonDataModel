using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningCodeDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningCodeDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEarningCodeDetailEntity";
            KeyPrefix = "commonDataModel.payrollearningcodedetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningCodeDetailEntity";

            AddGroup("Common Data Model PayrollEarningCodeDetailEntity Details", group =>
            {
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateBasis = group.Add(new VocabularyKey(nameof(RateBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFormula = group.Add(new VocabularyKey(nameof(DefaultFormula), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey RateBasis { get; private set; }
        public VocabularyKey DefaultFormula { get; private set; }


    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgManualPremiumEntityVocabulary : SimpleVocabulary
    {
        public JmgManualPremiumEntityVocabulary()
        {
            VocabularyName = "JmgManualPremiumEntity";
            KeyPrefix = "commonDataModel.jmgmanualpremiumentity";
            KeySeparator = ".";
            Grouping = "/JmgManualPremiumEntity";

            AddGroup("JmgManualPremiumEntity Details", group =>
            {
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremiumCode = group.Add(new VocabularyKey(nameof(PremiumCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCostType = group.Add(new VocabularyKey(nameof(PayCostType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey PremiumCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PayCostType { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }


    }
}
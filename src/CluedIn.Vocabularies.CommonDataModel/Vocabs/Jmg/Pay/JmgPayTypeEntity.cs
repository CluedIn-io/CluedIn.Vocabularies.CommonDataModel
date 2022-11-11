using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPayTypeEntityVocabulary : SimpleVocabulary
    {
        public JmgPayTypeEntityVocabulary()
        {
            VocabularyName = "JmgPayTypeEntity";
            KeyPrefix = "commonDataModel.jmgpaytypeentity";
            KeySeparator = ".";
            Grouping = "/JmgPayTypeEntity";

            AddGroup("JmgPayTypeEntity Details", group =>
            {
                PayType = group.Add(new VocabularyKey(nameof(PayType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasePayType = group.Add(new VocabularyKey(nameof(BasePayType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIncludedInExport = group.Add(new VocabularyKey(nameof(IsIncludedInExport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalPayCostType = group.Add(new VocabularyKey(nameof(ExternalPayCostType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PayType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BasePayType { get; private set; }
        public VocabularyKey IsIncludedInExport { get; private set; }
        public VocabularyKey ExternalPayCostType { get; private set; }


    }
}
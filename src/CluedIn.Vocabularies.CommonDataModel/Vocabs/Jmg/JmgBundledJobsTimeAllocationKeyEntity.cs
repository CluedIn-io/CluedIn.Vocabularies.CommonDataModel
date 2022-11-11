using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgBundledJobsTimeAllocationKeyEntityVocabulary : SimpleVocabulary
    {
        public JmgBundledJobsTimeAllocationKeyEntityVocabulary()
        {
            VocabularyName = "JmgBundledJobsTimeAllocationKeyEntity";
            KeyPrefix = "commonDataModel.jmgbundledjobstimeallocationkeyentity";
            KeySeparator = ".";
            Grouping = "/JmgBundledJobsTimeAllocationKeyEntity";

            AddGroup("JmgBundledJobsTimeAllocationKeyEntity Details", group =>
            {
                TimeAllocationMethod = group.Add(new VocabularyKey(nameof(TimeAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionUnitId = group.Add(new VocabularyKey(nameof(ProductionUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TimeAllocationMethod { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ProductionUnitId { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }


    }
}
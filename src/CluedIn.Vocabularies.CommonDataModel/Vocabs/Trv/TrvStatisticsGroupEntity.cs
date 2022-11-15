using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvStatisticsGroupEntityVocabulary : SimpleVocabulary
    {
        public TrvStatisticsGroupEntityVocabulary()
        {
            VocabularyName = "Trv Statistics Group Entity";
            KeyPrefix = "commonDataModel.trvstatisticsgroupentity";
            KeySeparator = ".";
            Grouping = "/TrvStatisticsGroupEntity";

            AddGroup("TrvStatisticsGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsGroup = group.Add(new VocabularyKey(nameof(StatisticsGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey StatisticsGroup { get; private set; }
    }
}
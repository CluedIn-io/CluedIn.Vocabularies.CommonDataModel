using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmProspectStatisticsDefaultsEntityVocabulary : SimpleVocabulary
    {
        public smmProspectStatisticsDefaultsEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmProspectStatisticsDefaultsEntity";
            KeyPrefix = "commonDataModel.smmprospectstatisticsdefaultsentity";
            KeySeparator = ".";
            Grouping = "/smmProspectStatisticsDefaultsEntity";

            AddGroup("Common Data Model smmProspectStatisticsDefaultsEntity Details", group =>
            {
                StatisticsPeriodTypeCode = group.Add(new VocabularyKey(nameof(StatisticsPeriodTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultStartDate = group.Add(new VocabularyKey(nameof(DefaultStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultEndDate = group.Add(new VocabularyKey(nameof(DefaultEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey StatisticsPeriodTypeCode { get; private set; }
public VocabularyKey DefaultStartDate { get; private set; }
public VocabularyKey DefaultEndDate { get; private set; }


    }
}
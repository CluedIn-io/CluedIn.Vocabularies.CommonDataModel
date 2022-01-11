using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatStatisticProcedureEntityVocabulary : SimpleVocabulary
    {
        public IntrastatStatisticProcedureEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatStatisticProcedureEntity";
            KeyPrefix = "commonDataModel.intrastatstatisticprocedureentity";
            KeySeparator = ".";
            Grouping = "/IntrastatStatisticProcedureEntity";

            AddGroup("Common Data Model IntrastatStatisticProcedureEntity Details", group =>
            {
                Text1 = group.Add(new VocabularyKey(nameof(Text1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Text2 = group.Add(new VocabularyKey(nameof(Text2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatisticProcedureId = group.Add(new VocabularyKey(nameof(StatisticProcedureId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommodityName = group.Add(new VocabularyKey(nameof(CommodityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Text1 { get; private set; }
public VocabularyKey Text2 { get; private set; }
public VocabularyKey StatisticProcedureId { get; private set; }
public VocabularyKey CommodityName { get; private set; }
public VocabularyKey CommodityHierarchyName { get; private set; }


    }
}
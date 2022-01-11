using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLaborStandardEntityVocabulary : SimpleVocabulary
    {
        public WHSLaborStandardEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLaborStandardEntity";
            KeyPrefix = "commonDataModel.whslaborstandardentity";
            KeySeparator = ".";
            Grouping = "/WHSLaborStandardEntity";

            AddGroup("Common Data Model WHSLaborStandardEntity Details", group =>
            {
                LaborStandardDescription = group.Add(new VocabularyKey(nameof(LaborStandardDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LaborStandardProductQuery = group.Add(new VocabularyKey(nameof(LaborStandardProductQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LaborStandardId = group.Add(new VocabularyKey(nameof(LaborStandardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LaborStandardWarehouseLocationQuery = group.Add(new VocabularyKey(nameof(LaborStandardWarehouseLocationQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LaborStandardDescription { get; private set; }
public VocabularyKey LaborStandardProductQuery { get; private set; }
public VocabularyKey LaborStandardId { get; private set; }
public VocabularyKey LaborStandardWarehouseLocationQuery { get; private set; }
public VocabularyKey WorkOrderType { get; private set; }


    }
}
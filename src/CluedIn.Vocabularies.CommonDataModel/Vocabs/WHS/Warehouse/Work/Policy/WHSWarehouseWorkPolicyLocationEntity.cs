using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkPolicyLocationEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkPolicyLocationEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkPolicyLocationEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkpolicylocationentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkPolicyLocationEntity";

            AddGroup("Common Data Model WHSWarehouseWorkPolicyLocationEntity Details", group =>
            {
                WHSPolicyRecId = group.Add(new VocabularyKey(nameof(WHSPolicyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkPolicyName = group.Add(new VocabularyKey(nameof(WorkPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WHSPolicyRecId { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey WarehouseLocationId { get; private set; }
public VocabularyKey WorkPolicyName { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSShipConsolidationPolicyFieldEntityVocabulary : SimpleVocabulary
    {
        public WHSShipConsolidationPolicyFieldEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSShipConsolidationPolicyFieldEntity";
            KeyPrefix = "commonDataModel.whsshipconsolidationpolicyfieldentity";
            KeySeparator = ".";
            Grouping = "/WHSShipConsolidationPolicyFieldEntity";

            AddGroup("Common Data Model WHSShipConsolidationPolicyFieldEntity Details", group =>
            {
                ShipConsolidationPolicyName = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceFieldName = group.Add(new VocabularyKey(nameof(SourceFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceTableName = group.Add(new VocabularyKey(nameof(SourceTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShipConsolidationPolicyType = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShipConsolidationPolicyName { get; private set; }
public VocabularyKey SourceFieldName { get; private set; }
public VocabularyKey SourceTableName { get; private set; }
public VocabularyKey ShipConsolidationPolicyType { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityTestVariableEntityVocabulary : SimpleVocabulary
    {
        public InventQualityTestVariableEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventQualityTestVariableEntity";
            KeyPrefix = "commonDataModel.inventqualitytestvariableentity";
            KeySeparator = ".";
            Grouping = "/InventQualityTestVariableEntity";

            AddGroup("Common Data Model InventQualityTestVariableEntity Details", group =>
            {
                VariableId = group.Add(new VocabularyKey(nameof(VariableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VariableDescription = group.Add(new VocabularyKey(nameof(VariableDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey VariableId { get; private set; }
public VocabularyKey VariableDescription { get; private set; }


    }
}
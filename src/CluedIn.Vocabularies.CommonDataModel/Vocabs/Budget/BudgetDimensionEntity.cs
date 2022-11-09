using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetDimensionEntityVocabulary : SimpleVocabulary
    {
        public BudgetDimensionEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetDimensionEntity";
            KeyPrefix = "commonDataModel.budgetdimensionentity";
            KeySeparator = ".";
            Grouping = "/BudgetDimensionEntity";

            AddGroup("Common Data Model BudgetDimensionEntity Details", group =>
            {
                DimensionAttribute = group.Add(new VocabularyKey(nameof(DimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLedger = group.Add(new VocabularyKey(nameof(PrimaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionAttributeId = group.Add(new VocabularyKey(nameof(DimensionAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DimensionAttribute { get; private set; }
public VocabularyKey PrimaryLedger { get; private set; }
public VocabularyKey DimensionAttributeId { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlDimensionAttributeEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlDimensionAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetControlDimensionAttributeEntity";
            KeyPrefix = "commonDataModel.budgetcontroldimensionattributeentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlDimensionAttributeEntity";

            AddGroup("Common Data Model BudgetControlDimensionAttributeEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionAttributeId = group.Add(new VocabularyKey(nameof(DimensionAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetControlConfiguration = group.Add(new VocabularyKey(nameof(BudgetControlConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetPrimaryLedgerDimensionAttribute = group.Add(new VocabularyKey(nameof(BudgetPrimaryLedgerDimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLedger = group.Add(new VocabularyKey(nameof(PrimaryLedger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey Position { get; private set; }
public VocabularyKey DimensionAttributeId { get; private set; }
public VocabularyKey BudgetControlConfiguration { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey BudgetPrimaryLedgerDimensionAttribute { get; private set; }
public VocabularyKey PrimaryLedger { get; private set; }


    }
}
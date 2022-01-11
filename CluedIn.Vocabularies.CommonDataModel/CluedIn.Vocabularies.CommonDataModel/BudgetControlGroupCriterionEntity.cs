using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetControlGroupCriterionEntityVocabulary : SimpleVocabulary
    {
        public BudgetControlGroupCriterionEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetControlGroupCriterionEntity";
            KeyPrefix = "commonDataModel.budgetcontrolgroupcriterionentity";
            KeySeparator = ".";
            Grouping = "/BudgetControlGroupCriterionEntity";

            AddGroup("Common Data Model BudgetControlGroupCriterionEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MemberName = group.Add(new VocabularyKey(nameof(MemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetControlDimensionAttribute = group.Add(new VocabularyKey(nameof(BudgetControlDimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetGroupMember = group.Add(new VocabularyKey(nameof(BudgetGroupMember), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionAttributeId = group.Add(new VocabularyKey(nameof(DimensionAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Criterion = group.Add(new VocabularyKey(nameof(Criterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey MemberName { get; private set; }
public VocabularyKey BudgetControlDimensionAttribute { get; private set; }
public VocabularyKey BudgetGroupMember { get; private set; }
public VocabularyKey DimensionAttributeId { get; private set; }
public VocabularyKey Criterion { get; private set; }


    }
}
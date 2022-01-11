using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseSubCategoryEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseSubCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvExpenseSubCategoryEntity";
            KeyPrefix = "commonDataModel.trvexpensesubcategoryentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseSubCategoryEntity";

            AddGroup("Common Data Model TrvExpenseSubCategoryEntity Details", group =>
            {
                ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInactive = group.Add(new VocabularyKey(nameof(IsInactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxItemGroupIfBilledToEmployee = group.Add(new VocabularyKey(nameof(TaxItemGroupIfBilledToEmployee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TrvSharedSubCategory = group.Add(new VocabularyKey(nameof(TrvSharedSubCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SharedSubCategoryName = group.Add(new VocabularyKey(nameof(SharedSubCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExpenseCategory { get; private set; }
public VocabularyKey DisplayOrder { get; private set; }
public VocabularyKey IsInactive { get; private set; }
public VocabularyKey LedgerDimension { get; private set; }
public VocabularyKey TaxItemGroup { get; private set; }
public VocabularyKey TaxItemGroupIfBilledToEmployee { get; private set; }
public VocabularyKey TrvSharedSubCategory { get; private set; }
public VocabularyKey SharedSubCategoryName { get; private set; }
public VocabularyKey LedgerDimensionDisplayValue { get; private set; }


    }
}
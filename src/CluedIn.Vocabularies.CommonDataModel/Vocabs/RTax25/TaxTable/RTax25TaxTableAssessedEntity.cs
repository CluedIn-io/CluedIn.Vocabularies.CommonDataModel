using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25TaxTableAssessedEntityVocabulary : SimpleVocabulary
    {
        public RTax25TaxTableAssessedEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTax25TaxTableAssessedEntity";
            KeyPrefix = "commonDataModel.rtax25taxtableassessedentity";
            KeySeparator = ".";
            Grouping = "/RTax25TaxTableAssessedEntity";

            AddGroup("Common Data Model RTax25TaxTableAssessedEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeOfTax = group.Add(new VocabularyKey(nameof(TypeOfTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetRevenueCode = group.Add(new VocabularyKey(nameof(BudgetRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceByReductionOfRate = group.Add(new VocabularyKey(nameof(AllowanceByReductionOfRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceByReductionOfRateValue = group.Add(new VocabularyKey(nameof(AllowanceByReductionOfRateValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceByReductionOfTax = group.Add(new VocabularyKey(nameof(AllowanceByReductionOfTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceByReductionOfTaxValue = group.Add(new VocabularyKey(nameof(AllowanceByReductionOfTaxValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceDecreaseBase387 = group.Add(new VocabularyKey(nameof(AllowanceDecreaseBase387), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceDecreaseBase387Value = group.Add(new VocabularyKey(nameof(AllowanceDecreaseBase387Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceDecreaseBase391 = group.Add(new VocabularyKey(nameof(AllowanceDecreaseBase391), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowanceDecreaseBase391Value = group.Add(new VocabularyKey(nameof(AllowanceDecreaseBase391Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MainAccount { get; private set; }
public VocabularyKey TypeOfTax { get; private set; }
public VocabularyKey Code { get; private set; }
public VocabularyKey Module { get; private set; }
public VocabularyKey MainAccountDisplayValue { get; private set; }
public VocabularyKey BudgetRevenueCode { get; private set; }
public VocabularyKey AllowanceByReductionOfRate { get; private set; }
public VocabularyKey AllowanceByReductionOfRateValue { get; private set; }
public VocabularyKey AllowanceByReductionOfTax { get; private set; }
public VocabularyKey AllowanceByReductionOfTaxValue { get; private set; }
public VocabularyKey AllowanceDecreaseBase387 { get; private set; }
public VocabularyKey AllowanceDecreaseBase387Value { get; private set; }
public VocabularyKey AllowanceDecreaseBase391 { get; private set; }
public VocabularyKey AllowanceDecreaseBase391Value { get; private set; }


    }
}
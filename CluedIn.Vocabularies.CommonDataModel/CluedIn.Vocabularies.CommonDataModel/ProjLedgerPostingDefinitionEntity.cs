using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjLedgerPostingDefinitionEntityVocabulary : SimpleVocabulary
    {
        public ProjLedgerPostingDefinitionEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjLedgerPostingDefinitionEntity";
            KeyPrefix = "commonDataModel.projledgerpostingdefinitionentity";
            KeySeparator = ".";
            Grouping = "/ProjLedgerPostingDefinitionEntity";

            AddGroup("Common Data Model ProjLedgerPostingDefinitionEntity Details", group =>
            {
                ProjectAccountType = group.Add(new VocabularyKey(nameof(ProjectAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectGroup = group.Add(new VocabularyKey(nameof(ProjectGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryGroup = group.Add(new VocabularyKey(nameof(CategoryGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjFundingSource = group.Add(new VocabularyKey(nameof(ProjFundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSourceId = group.Add(new VocabularyKey(nameof(FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjCode = group.Add(new VocabularyKey(nameof(ProjCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryCode = group.Add(new VocabularyKey(nameof(CategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjRelation = group.Add(new VocabularyKey(nameof(ProjRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjCategoryRelation = group.Add(new VocabularyKey(nameof(ProjCategoryRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BorrowingLegalEntity = group.Add(new VocabularyKey(nameof(BorrowingLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LendingLegalEntity = group.Add(new VocabularyKey(nameof(LendingLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProjectAccountType { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey ProjectGroup { get; private set; }
public VocabularyKey CategoryId { get; private set; }
public VocabularyKey CategoryGroup { get; private set; }
public VocabularyKey ProjFundingSource { get; private set; }
public VocabularyKey TaxGroupId { get; private set; }
public VocabularyKey ProjectContractId { get; private set; }
public VocabularyKey FundingSourceId { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey ProjCode { get; private set; }
public VocabularyKey CategoryCode { get; private set; }
public VocabularyKey ProjRelation { get; private set; }
public VocabularyKey ProjCategoryRelation { get; private set; }
public VocabularyKey BorrowingLegalEntity { get; private set; }
public VocabularyKey LendingLegalEntity { get; private set; }


    }
}
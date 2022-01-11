using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionExpenditureReviewerFinancialDimensionConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionExpenditureReviewerFinancialDimensionConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseRequisitionExpenditureReviewerFinancialDimensionConfigurationEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionexpenditurereviewerfinancialdimensionconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionExpenditureReviewerFinancialDimensionConfigurationEntity";

            AddGroup("Common Data Model PurchPurchaseRequisitionExpenditureReviewerFinancialDimensionConfigurationEntity Details", group =>
            {
                PurchaseRequisitionExpenditureReviewerConfigurationName = group.Add(new VocabularyKey(nameof(PurchaseRequisitionExpenditureReviewerConfigurationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FinancialDimensionName = group.Add(new VocabularyKey(nameof(FinancialDimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionType = group.Add(new VocabularyKey(nameof(AccountingDistributionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFinancialDimensionActive = group.Add(new VocabularyKey(nameof(IsFinancialDimensionActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PurchaseRequisitionExpenditureReviewerConfigurationName { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey FinancialDimensionName { get; private set; }
public VocabularyKey AccountingDistributionType { get; private set; }
public VocabularyKey IsFinancialDimensionActive { get; private set; }


    }
}
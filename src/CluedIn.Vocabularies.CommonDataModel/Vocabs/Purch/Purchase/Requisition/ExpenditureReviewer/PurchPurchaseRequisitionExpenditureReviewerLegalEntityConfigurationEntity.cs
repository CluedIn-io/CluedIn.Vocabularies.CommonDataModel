using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionExpenditureReviewerLegalEntityConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionExpenditureReviewerLegalEntityConfigurationEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Requisition Expenditure Reviewer Legal Entity Configuration Entity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionexpenditurereviewerlegalentityconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionExpenditureReviewerLegalEntityConfigurationEntity";

            AddGroup("PurchPurchaseRequisitionExpenditureReviewerLegalEntityConfigurationEntity Details", group =>
            {
                IsProjectControllerExpenditureReviewer = group.Add(new VocabularyKey(nameof(IsProjectControllerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectManagerExpenditureReviewer = group.Add(new VocabularyKey(nameof(IsProjectManagerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectSalesManagerExpenditureReviewer = group.Add(new VocabularyKey(nameof(IsProjectSalesManagerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionExpenditureReviewerConfigurationName = group.Add(new VocabularyKey(nameof(PurchaseRequisitionExpenditureReviewerConfigurationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsProjectControllerExpenditureReviewer { get; private set; }
        public VocabularyKey IsProjectManagerExpenditureReviewer { get; private set; }
        public VocabularyKey IsProjectSalesManagerExpenditureReviewer { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey PurchaseRequisitionExpenditureReviewerConfigurationName { get; private set; }
    }
}
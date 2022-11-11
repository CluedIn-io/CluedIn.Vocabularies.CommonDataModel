using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderExpenditureReviewPolicyEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderExpenditureReviewPolicyEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseOrderExpenditureReviewPolicyEntity";
            KeyPrefix = "commonDataModel.purchpurchaseorderexpenditurereviewpolicyentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderExpenditureReviewPolicyEntity";

            AddGroup("PurchPurchaseOrderExpenditureReviewPolicyEntity Details", group =>
            {
                IsProjectControllerExpenditureReviewer = group.Add(new VocabularyKey(nameof(IsProjectControllerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectManagerExpenditureReviewer = group.Add(new VocabularyKey(nameof(IsProjectManagerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectSalesManagerExpenditureReviewer = group.Add(new VocabularyKey(nameof(IsProjectSalesManagerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreOrganizationFinancialDimensionOwnerExpenditureReviewer = group.Add(new VocabularyKey(nameof(AreOrganizationFinancialDimensionOwnerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreProjectFinancialDimensionOwnerExpenditureReviewer = group.Add(new VocabularyKey(nameof(AreProjectFinancialDimensionOwnerExpenditureReviewer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Token = group.Add(new VocabularyKey(nameof(Token), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreOrganizationFinancialDimensionOwnerExpenditureReviewerDisplayValue = group.Add(new VocabularyKey(nameof(AreOrganizationFinancialDimensionOwnerExpenditureReviewerDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreProjectFinancialDimensionOwnerExpenditureReviewerDisplayValue = group.Add(new VocabularyKey(nameof(AreProjectFinancialDimensionOwnerExpenditureReviewerDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsProjectControllerExpenditureReviewer { get; private set; }
        public VocabularyKey IsProjectManagerExpenditureReviewer { get; private set; }
        public VocabularyKey IsProjectSalesManagerExpenditureReviewer { get; private set; }
        public VocabularyKey AreOrganizationFinancialDimensionOwnerExpenditureReviewer { get; private set; }
        public VocabularyKey AreProjectFinancialDimensionOwnerExpenditureReviewer { get; private set; }
        public VocabularyKey Token { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey AreOrganizationFinancialDimensionOwnerExpenditureReviewerDisplayValue { get; private set; }
        public VocabularyKey AreProjectFinancialDimensionOwnerExpenditureReviewerDisplayValue { get; private set; }


    }
}
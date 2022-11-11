using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProductComplianceParametersEntityVocabulary : SimpleVocabulary
    {
        public InventProductComplianceParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventProductComplianceParametersEntity";
            KeyPrefix = "commonDataModel.inventproductcomplianceparametersentity";
            KeySeparator = ".";
            Grouping = "/InventProductComplianceParametersEntity";

            AddGroup("Common Data Model InventProductComplianceParametersEntity Details", group =>
            {
                ProductComplianceAdministratorUserId = group.Add(new VocabularyKey(nameof(ProductComplianceAdministratorUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductDataSheetValidityDays = group.Add(new VocabularyKey(nameof(DefaultProductDataSheetValidityDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultExpiryAdviceDays = group.Add(new VocabularyKey(nameof(DefaultExpiryAdviceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnnualCalculationBasisStartDate = group.Add(new VocabularyKey(nameof(AnnualCalculationBasisStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnnualCalculationBasisEndDate = group.Add(new VocabularyKey(nameof(AnnualCalculationBasisEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesOrderEntryIssueRegulationWarning = group.Add(new VocabularyKey(nameof(WillSalesOrderEntryIssueRegulationWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseOrderEntryIssueRegulationWarning = group.Add(new VocabularyKey(nameof(WillPurchaseOrderEntryIssueRegulationWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPackingSlipPostingIssueRegulationWarning = group.Add(new VocabularyKey(nameof(WillSalesPackingSlipPostingIssueRegulationWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPackingSlipPrintingIncludeProductSafetyDataSheet = group.Add(new VocabularyKey(nameof(WillSalesPackingSlipPrintingIncludeProductSafetyDataSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillExpiredProductSafetyDataSheetPreventSalesPackingSlipProcessing = group.Add(new VocabularyKey(nameof(WillExpiredProductSafetyDataSheetPreventSalesPackingSlipProcessing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDayBasisType = group.Add(new VocabularyKey(nameof(EffectiveDayBasisType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductSafetyDataSheetModificationRequireReasonEntry = group.Add(new VocabularyKey(nameof(WillProductSafetyDataSheetModificationRequireReasonEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesProcessesCreateExpiredProductSafetyDataSheetAlerts = group.Add(new VocabularyKey(nameof(WillSalesProcessesCreateExpiredProductSafetyDataSheetAlerts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesProcessesCreateExpiryAdvicePeriodProductSafetyDataSheetAlerts = group.Add(new VocabularyKey(nameof(WillSalesProcessesCreateExpiryAdvicePeriodProductSafetyDataSheetAlerts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseProcessesCreateExpiredProductSafetyDataSheetAlerts = group.Add(new VocabularyKey(nameof(WillPurchaseProcessesCreateExpiredProductSafetyDataSheetAlerts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseProcessesCreateExpiryAdvicePeriodProductSafetyDataSheetAlerts = group.Add(new VocabularyKey(nameof(WillPurchaseProcessesCreateExpiryAdvicePeriodProductSafetyDataSheetAlerts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductComplianceAdministratorUserId { get; private set; }
        public VocabularyKey DefaultProductDataSheetValidityDays { get; private set; }
        public VocabularyKey DefaultExpiryAdviceDays { get; private set; }
        public VocabularyKey AnnualCalculationBasisStartDate { get; private set; }
        public VocabularyKey AnnualCalculationBasisEndDate { get; private set; }
        public VocabularyKey WillSalesOrderEntryIssueRegulationWarning { get; private set; }
        public VocabularyKey WillPurchaseOrderEntryIssueRegulationWarning { get; private set; }
        public VocabularyKey WillSalesPackingSlipPostingIssueRegulationWarning { get; private set; }
        public VocabularyKey WillSalesPackingSlipPrintingIncludeProductSafetyDataSheet { get; private set; }
        public VocabularyKey WillExpiredProductSafetyDataSheetPreventSalesPackingSlipProcessing { get; private set; }
        public VocabularyKey EffectiveDayBasisType { get; private set; }
        public VocabularyKey WillProductSafetyDataSheetModificationRequireReasonEntry { get; private set; }
        public VocabularyKey WillSalesProcessesCreateExpiredProductSafetyDataSheetAlerts { get; private set; }
        public VocabularyKey WillSalesProcessesCreateExpiryAdvicePeriodProductSafetyDataSheetAlerts { get; private set; }
        public VocabularyKey WillPurchaseProcessesCreateExpiredProductSafetyDataSheetAlerts { get; private set; }
        public VocabularyKey WillPurchaseProcessesCreateExpiryAdvicePeriodProductSafetyDataSheetAlerts { get; private set; }


    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceSubscriptionParametersEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceSubscriptionParametersEntityVocabulary()
        {
            VocabularyName = "SMA Service Subscription Parameters Entity";
            KeyPrefix = "commonDataModel.smaservicesubscriptionparametersentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceSubscriptionParametersEntity";

            AddGroup("SMAServiceSubscriptionParametersEntity Details", group =>
            {
                WillInvoiceProcessingUpdateProjectDate = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingUpdateProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAccruedRevenueCalculationUseCalendarDays = group.Add(new VocabularyKey(nameof(WillAccruedRevenueCalculationUseCalendarDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAccruedPeriodsDeleted = group.Add(new VocabularyKey(nameof(AreAccruedPeriodsDeleted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditingAccrualReversingMethod = group.Add(new VocabularyKey(nameof(CreditingAccrualReversingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualRoundingOffPeriod = group.Add(new VocabularyKey(nameof(AccrualRoundingOffPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WillInvoiceProcessingUpdateProjectDate { get; private set; }
        public VocabularyKey WillAccruedRevenueCalculationUseCalendarDays { get; private set; }
        public VocabularyKey AreAccruedPeriodsDeleted { get; private set; }
        public VocabularyKey CreditingAccrualReversingMethod { get; private set; }
        public VocabularyKey AccrualRoundingOffPeriod { get; private set; }
    }
}
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceSubscriptionGroupEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceSubscriptionGroupEntityVocabulary()
        {
            VocabularyName = "SMAServiceSubscriptionGroupEntity";
            KeyPrefix = "commonDataModel.smaservicesubscriptiongroupentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceSubscriptionGroupEntity";

            AddGroup("SMAServiceSubscriptionGroupEntity Details", group =>
            {
                InvoiceFrequencyPeriodTypeCode = group.Add(new VocabularyKey(nameof(InvoiceFrequencyPeriodTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualFrequencyPeriodTypeCode = group.Add(new VocabularyKey(nameof(AccrualFrequencyPeriodTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRevenueAccrued = group.Add(new VocabularyKey(nameof(IsRevenueAccrued), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceSubscriptionNumberSequenceRecId = group.Add(new VocabularyKey(nameof(ServiceSubscriptionNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceSubscriptionNumberSequenceCode = group.Add(new VocabularyKey(nameof(ServiceSubscriptionNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceSubscriptionNumberSequenceDataArea = group.Add(new VocabularyKey(nameof(ServiceSubscriptionNumberSequenceDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InvoiceFrequencyPeriodTypeCode { get; private set; }
        public VocabularyKey AccrualFrequencyPeriodTypeCode { get; private set; }
        public VocabularyKey IsRevenueAccrued { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey ServiceSubscriptionNumberSequenceRecId { get; private set; }
        public VocabularyKey ServiceSubscriptionNumberSequenceCode { get; private set; }
        public VocabularyKey ServiceSubscriptionNumberSequenceDataArea { get; private set; }


    }
}
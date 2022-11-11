using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentDayLineCdsV2EntityVocabulary : SimpleVocabulary
    {
        public PaymentDayLineCdsV2EntityVocabulary()
        {
            VocabularyName = "PaymentDayLineCdsV2Entity";
            KeyPrefix = "commonDataModel.paymentdaylinecdsv2entity";
            KeySeparator = ".";
            Grouping = "/PaymentDayLineCdsV2Entity";

            AddGroup("PaymentDayLineCdsV2Entity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DayOfMonth = group.Add(new VocabularyKey(nameof(DayOfMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DayOfWeek = group.Add(new VocabularyKey(nameof(DayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey DayOfMonth { get; private set; }
        public VocabularyKey DayOfWeek { get; private set; }


    }
}
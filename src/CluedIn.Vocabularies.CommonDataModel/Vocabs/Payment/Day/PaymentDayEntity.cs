using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentDayEntityVocabulary : SimpleVocabulary
    {
        public PaymentDayEntityVocabulary()
        {
            VocabularyName = "PaymentDayEntity";
            KeyPrefix = "commonDataModel.paymentdayentity";
            KeySeparator = ".";
            Grouping = "/PaymentDayEntity";

            AddGroup("PaymentDayEntity Details", group =>
            {
                DayOfMonth = group.Add(new VocabularyKey(nameof(DayOfMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DayOfWeek = group.Add(new VocabularyKey(nameof(DayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DayOfMonth { get; private set; }
        public VocabularyKey DayOfWeek { get; private set; }
        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}
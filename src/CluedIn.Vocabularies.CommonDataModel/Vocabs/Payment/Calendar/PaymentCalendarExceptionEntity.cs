using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentCalendarExceptionEntityVocabulary : SimpleVocabulary
    {
        public PaymentCalendarExceptionEntityVocabulary()
        {
            VocabularyName = "PaymentCalendarExceptionEntity";
            KeyPrefix = "commonDataModel.paymentcalendarexceptionentity";
            KeySeparator = ".";
            Grouping = "/PaymentCalendarExceptionEntity";

            AddGroup("PaymentCalendarExceptionEntity Details", group =>
            {
                PaymentCalendar = group.Add(new VocabularyKey(nameof(PaymentCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentCalendarName = group.Add(new VocabularyKey(nameof(PaymentCalendarName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionDate = group.Add(new VocabularyKey(nameof(ExceptionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionType = group.Add(new VocabularyKey(nameof(ExceptionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PaymentCalendar { get; private set; }
        public VocabularyKey PaymentCalendarName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExceptionDate { get; private set; }
        public VocabularyKey ExceptionType { get; private set; }


    }
}
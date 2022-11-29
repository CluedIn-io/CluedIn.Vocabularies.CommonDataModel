using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class PaymentScheduleVocabulary : SimpleVocabulary
    {
        public PaymentScheduleVocabulary()
        {
            VocabularyName = "Payment Schedule";
            KeyPrefix = "commonDataModel.paymentschedule.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/PaymentSchedule";

            AddGroup("PaymentSchedule Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    FirstPaymentDate = group.Add(new VocabularyKey(nameof(FirstPaymentDate), "First Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Frequency = group.Add(new VocabularyKey(nameof(Frequency), "Frequency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FrequencyInterval = group.Add(new VocabularyKey(nameof(FrequencyInterval), "Frequency Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastPaymentDate = group.Add(new VocabularyKey(nameof(LastPaymentDate), "Last Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmount = group.Add(new VocabularyKey(nameof(NextPaymentAmount), "Next Payment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmountBase = group.Add(new VocabularyKey(nameof(NextPaymentAmountBase), "Next Payment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentDate = group.Add(new VocabularyKey(nameof(NextPaymentDate), "Next Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfPayments = group.Add(new VocabularyKey(nameof(NumberOfPayments), "Number of Payments", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PaymentScheduleId = group.Add(new VocabularyKey(nameof(PaymentScheduleId), "Payment Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecurringAmount = group.Add(new VocabularyKey(nameof(RecurringAmount), "Recurring Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RecurringAmountBase = group.Add(new VocabularyKey(nameof(RecurringAmountBase), "Recurring Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), "Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmountBase = group.Add(new VocabularyKey(nameof(TotalAmountBase), "Total Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey FirstPaymentDate { get; private set; }
        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey FrequencyInterval { get; private set; }
        public VocabularyKey LastPaymentDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NextPaymentAmount { get; private set; }
        public VocabularyKey NextPaymentAmountBase { get; private set; }
        public VocabularyKey NextPaymentDate { get; private set; }
        public VocabularyKey NumberOfPayments { get; private set; }
        public VocabularyKey PaymentScheduleId { get; private set; }
        public VocabularyKey RecurringAmount { get; private set; }
        public VocabularyKey RecurringAmountBase { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey TotalAmountBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
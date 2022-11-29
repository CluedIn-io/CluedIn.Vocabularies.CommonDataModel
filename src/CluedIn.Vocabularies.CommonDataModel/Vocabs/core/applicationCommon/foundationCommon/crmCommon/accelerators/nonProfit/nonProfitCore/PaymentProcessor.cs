using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class PaymentProcessorVocabulary : SimpleVocabulary
    {
        public PaymentProcessorVocabulary()
        {
            VocabularyName = "Payment Processor";
            KeyPrefix = "commonDataModel.paymentprocessor.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/PaymentProcessor";

            AddGroup("PaymentProcessor Details for NonProfitCore", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentProcessorId = group.Add(new VocabularyKey(nameof(PaymentProcessorId), "Payment Processor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentProcessorId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
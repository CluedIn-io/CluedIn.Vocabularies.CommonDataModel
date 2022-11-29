using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class CreditPlanRecipientVocabulary : SimpleVocabulary
    {
        public CreditPlanRecipientVocabulary()
        {
            VocabularyName = "Credit Plan Recipient";
            KeyPrefix = "commonDataModel.creditplanrecipient.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/CreditPlanRecipient";

            AddGroup("CreditPlanRecipient Details for NonProfitCore", group =>
            {
			    CreditRecipientId = group.Add(new VocabularyKey(nameof(CreditRecipientId), "Credit Plan Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PercentageOfPayment = group.Add(new VocabularyKey(nameof(PercentageOfPayment), "Percentage of Payment", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SoftCreditReason = group.Add(new VocabularyKey(nameof(SoftCreditReason), "Soft Credit Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreditRecipientId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PercentageOfPayment { get; private set; }
        public VocabularyKey SoftCreditReason { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class PaymentScheduleVocabulary : SimpleVocabulary
    {
        public PaymentScheduleVocabulary()
        {
            VocabularyName = "Payment Schedule";
            KeyPrefix = "commonDataModel.paymentschedule.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/PaymentSchedule";

            AddGroup("PaymentSchedule Details for NonProfitIati", group =>
            {
			                 
            });
        }

        
    }
}
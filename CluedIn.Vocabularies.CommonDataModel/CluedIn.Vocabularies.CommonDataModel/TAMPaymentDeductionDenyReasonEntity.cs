using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMPaymentDeductionDenyReasonEntityVocabulary : SimpleVocabulary
    {
        public TAMPaymentDeductionDenyReasonEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMPaymentDeductionDenyReasonEntity";
            KeyPrefix = "commonDataModel.tampaymentdeductiondenyreasonentity";
            KeySeparator = ".";
            Grouping = "/TAMPaymentDeductionDenyReasonEntity";

            AddGroup("Common Data Model TAMPaymentDeductionDenyReasonEntity Details", group =>
            {
                PaymentDeductionDenyReasonCode = group.Add(new VocabularyKey(nameof(PaymentDeductionDenyReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PaymentDeductionDenyReasonCode { get; private set; }
public VocabularyKey ReasonDescription { get; private set; }


    }
}
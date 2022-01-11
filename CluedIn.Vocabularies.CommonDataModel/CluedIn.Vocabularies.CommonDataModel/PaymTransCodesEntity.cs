using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymTransCodesEntityVocabulary : SimpleVocabulary
    {
        public PaymTransCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymTransCodesEntity";
            KeyPrefix = "commonDataModel.paymtranscodesentity";
            KeySeparator = ".";
            Grouping = "/PaymTransCodesEntity";

            AddGroup("Common Data Model PaymTransCodesEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTransactionCode = group.Add(new VocabularyKey(nameof(PaymentTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey PaymentTransactionCode { get; private set; }


    }
}
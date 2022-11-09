using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentTransCodesEntityVocabulary : SimpleVocabulary
    {
        public PaymentTransCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentTransCodesEntity";
            KeyPrefix = "commonDataModel.paymenttranscodesentity";
            KeySeparator = ".";
            Grouping = "/PaymentTransCodesEntity";

            AddGroup("Common Data Model PaymentTransCodesEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTransactionCode = group.Add(new VocabularyKey(nameof(PaymentTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey PaymentTransactionCode { get; private set; }


    }
}
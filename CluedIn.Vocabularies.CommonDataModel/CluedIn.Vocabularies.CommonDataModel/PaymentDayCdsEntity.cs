using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentDayCdsEntityVocabulary : SimpleVocabulary
    {
        public PaymentDayCdsEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentDayCdsEntity";
            KeyPrefix = "commonDataModel.paymentdaycdsentity";
            KeySeparator = ".";
            Grouping = "/PaymentDayCdsEntity";

            AddGroup("Common Data Model PaymentDayCdsEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}
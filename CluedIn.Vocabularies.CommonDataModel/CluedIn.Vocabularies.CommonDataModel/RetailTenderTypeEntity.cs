using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTenderTypeEntityVocabulary : SimpleVocabulary
    {
        public RetailTenderTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTenderTypeEntity";
            KeyPrefix = "commonDataModel.retailtendertypeentity";
            KeySeparator = ".";
            Grouping = "/RetailTenderTypeEntity";

            AddGroup("Common Data Model RetailTenderTypeEntity Details", group =>
            {
                DefaultFunction = group.Add(new VocabularyKey(nameof(DefaultFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentMethodNumber = group.Add(new VocabularyKey(nameof(PaymentMethodNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefaultFunction { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey PaymentMethodNumber { get; private set; }


    }
}
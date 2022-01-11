using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRefundMethodEntityVocabulary : SimpleVocabulary
    {
        public MCRRefundMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRRefundMethodEntity";
            KeyPrefix = "commonDataModel.mcrrefundmethodentity";
            KeySeparator = ".";
            Grouping = "/MCRRefundMethodEntity";

            AddGroup("Common Data Model MCRRefundMethodEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentMode = group.Add(new VocabularyKey(nameof(PaymentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TenderTypeId = group.Add(new VocabularyKey(nameof(TenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey PaymentMode { get; private set; }
public VocabularyKey TenderTypeId { get; private set; }


    }
}
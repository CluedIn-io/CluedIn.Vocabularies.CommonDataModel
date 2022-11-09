using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelCurrencyEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelCurrencyEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailChannelCurrencyEntity";
            KeyPrefix = "commonDataModel.retailchannelcurrencyentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelCurrencyEntity";

            AddGroup("Common Data Model RetailChannelCurrencyEntity Details", group =>
            {
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OMOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OMOperatingUnitID = group.Add(new VocabularyKey(nameof(OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Channel { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey OMOperatingUnitNumber { get; private set; }
public VocabularyKey OMOperatingUnitID { get; private set; }


    }
}
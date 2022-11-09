using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxServiceTariffNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxServiceTariffNumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxServiceTariffNumberEntity";
            KeyPrefix = "commonDataModel.taxservicetariffnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxServiceTariffNumberEntity";

            AddGroup("Common Data Model TaxServiceTariffNumberEntity Details", group =>
            {
                ServiceTariffNumber = group.Add(new VocabularyKey(nameof(ServiceTariffNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceTariffDescription = group.Add(new VocabularyKey(nameof(ServiceTariffDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ServiceTariffNumber { get; private set; }
public VocabularyKey ServiceTariffDescription { get; private set; }


    }
}
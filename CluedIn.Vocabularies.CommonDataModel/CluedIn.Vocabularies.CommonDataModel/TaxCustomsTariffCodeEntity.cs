using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCustomsTariffCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxCustomsTariffCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxCustomsTariffCodeEntity";
            KeyPrefix = "commonDataModel.taxcustomstariffcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxCustomsTariffCodeEntity";

            AddGroup("Common Data Model TaxCustomsTariffCodeEntity Details", group =>
            {
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TariffCode = group.Add(new VocabularyKey(nameof(TariffCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Direction { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey TariffCode { get; private set; }


    }
}
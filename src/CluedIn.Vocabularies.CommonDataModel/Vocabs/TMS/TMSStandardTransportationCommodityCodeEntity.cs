using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSStandardTransportationCommodityCodeEntityVocabulary : SimpleVocabulary
    {
        public TMSStandardTransportationCommodityCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSStandardTransportationCommodityCodeEntity";
            KeyPrefix = "commonDataModel.tmsstandardtransportationcommoditycodeentity";
            KeySeparator = ".";
            Grouping = "/TMSStandardTransportationCommodityCodeEntity";

            AddGroup("Common Data Model TMSStandardTransportationCommodityCodeEntity Details", group =>
            {
                StandardTransportationCommodityCodeName = group.Add(new VocabularyKey(nameof(StandardTransportationCommodityCodeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StandardTransportationCommodityCode = group.Add(new VocabularyKey(nameof(StandardTransportationCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey StandardTransportationCommodityCodeName { get; private set; }
public VocabularyKey StandardTransportationCommodityCode { get; private set; }


    }
}
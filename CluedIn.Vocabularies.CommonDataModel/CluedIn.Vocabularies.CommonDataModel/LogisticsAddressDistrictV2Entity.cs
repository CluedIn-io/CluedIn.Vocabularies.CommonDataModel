using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressDistrictV2EntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressDistrictV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressDistrictV2Entity";
            KeyPrefix = "commonDataModel.logisticsaddressdistrictv2entity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressDistrictV2Entity";

            AddGroup("Common Data Model LogisticsAddressDistrictV2Entity Details", group =>
            {
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CityKey = group.Add(new VocabularyKey(nameof(CityKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
District = group.Add(new VocabularyKey(nameof(District), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountyId = group.Add(new VocabularyKey(nameof(CountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey City { get; private set; }
public VocabularyKey CityKey { get; private set; }
public VocabularyKey District { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey CountyId { get; private set; }
public VocabularyKey StateId { get; private set; }


    }
}
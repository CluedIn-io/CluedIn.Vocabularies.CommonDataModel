using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressEnterpriseZipCodeJapanEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressEnterpriseZipCodeJapanEntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressEnterpriseZipCodeJapanEntity";
            KeyPrefix = "commonDataModel.logisticsaddressenterprisezipcodejapanentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressEnterpriseZipCodeJapanEntity";

            AddGroup("Common Data Model LogisticsAddressEnterpriseZipCodeJapanEntity Details", group =>
            {
                KanjiCity = group.Add(new VocabularyKey(nameof(KanjiCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CityRecId = group.Add(new VocabularyKey(nameof(CityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KanjiDistrict = group.Add(new VocabularyKey(nameof(KanjiDistrict), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KanjiPrefecture = group.Add(new VocabularyKey(nameof(KanjiPrefecture), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StreetName = group.Add(new VocabularyKey(nameof(StreetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IndividualEnterpriseBuildingNumber = group.Add(new VocabularyKey(nameof(IndividualEnterpriseBuildingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KanjiEnterpriseName = group.Add(new VocabularyKey(nameof(KanjiEnterpriseName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KanjiStreet = group.Add(new VocabularyKey(nameof(KanjiStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey KanjiCity { get; private set; }
public VocabularyKey CityRecId { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey KanjiDistrict { get; private set; }
public VocabularyKey KanjiPrefecture { get; private set; }
public VocabularyKey StreetName { get; private set; }
public VocabularyKey IndividualEnterpriseBuildingNumber { get; private set; }
public VocabularyKey KanjiEnterpriseName { get; private set; }
public VocabularyKey KanjiStreet { get; private set; }


    }
}
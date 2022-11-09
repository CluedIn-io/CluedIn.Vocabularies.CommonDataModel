using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasHouseEntityVocabulary : SimpleVocabulary
    {
        public FiasHouseEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiasHouseEntity";
            KeyPrefix = "commonDataModel.fiashouseentity";
            KeySeparator = ".";
            Grouping = "/FiasHouseEntity";

            AddGroup("Common Data Model FiasHouseEntity Details", group =>
            {
                HouseId = group.Add(new VocabularyKey(nameof(HouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HouseGuid = group.Add(new VocabularyKey(nameof(HouseGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AOGuid = group.Add(new VocabularyKey(nameof(AOGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HouseNum = group.Add(new VocabularyKey(nameof(HouseNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BuildNum = group.Add(new VocabularyKey(nameof(BuildNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StrucNum = group.Add(new VocabularyKey(nameof(StrucNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DivType = group.Add(new VocabularyKey(nameof(DivType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstStatus = group.Add(new VocabularyKey(nameof(EstStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StrStatus = group.Add(new VocabularyKey(nameof(StrStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IFNSFL = group.Add(new VocabularyKey(nameof(IFNSFL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TerrIFNSFL = group.Add(new VocabularyKey(nameof(TerrIFNSFL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OKATO = group.Add(new VocabularyKey(nameof(OKATO), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey HouseId { get; private set; }
public VocabularyKey HouseGuid { get; private set; }
public VocabularyKey AOGuid { get; private set; }
public VocabularyKey HouseNum { get; private set; }
public VocabularyKey BuildNum { get; private set; }
public VocabularyKey StrucNum { get; private set; }
public VocabularyKey DivType { get; private set; }
public VocabularyKey EstStatus { get; private set; }
public VocabularyKey StrStatus { get; private set; }
public VocabularyKey PostalCode { get; private set; }
public VocabularyKey IFNSFL { get; private set; }
public VocabularyKey TerrIFNSFL { get; private set; }
public VocabularyKey OKATO { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey EndDate { get; private set; }


    }
}
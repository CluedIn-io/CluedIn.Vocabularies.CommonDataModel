using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasAddressObjectEntityVocabulary : SimpleVocabulary
    {
        public FiasAddressObjectEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiasAddressObjectEntity";
            KeyPrefix = "commonDataModel.fiasaddressobjectentity";
            KeySeparator = ".";
            Grouping = "/FiasAddressObjectEntity";

            AddGroup("Common Data Model FiasAddressObjectEntity Details", group =>
            {
                AOId = group.Add(new VocabularyKey(nameof(AOId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AOGuid = group.Add(new VocabularyKey(nameof(AOGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AOLevel = group.Add(new VocabularyKey(nameof(AOLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegionCode = group.Add(new VocabularyKey(nameof(RegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreaCode = group.Add(new VocabularyKey(nameof(AreaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CityCode = group.Add(new VocabularyKey(nameof(CityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CtArCode = group.Add(new VocabularyKey(nameof(CtArCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlaceCode = group.Add(new VocabularyKey(nameof(PlaceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlanCode = group.Add(new VocabularyKey(nameof(PlanCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StreetCode = group.Add(new VocabularyKey(nameof(StreetCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExtrCode = group.Add(new VocabularyKey(nameof(ExtrCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActStatus = group.Add(new VocabularyKey(nameof(ActStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LiveStatus = group.Add(new VocabularyKey(nameof(LiveStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperStatus = group.Add(new VocabularyKey(nameof(OperStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffName = group.Add(new VocabularyKey(nameof(OffName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentGuid = group.Add(new VocabularyKey(nameof(ParentGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IFNSFL = group.Add(new VocabularyKey(nameof(IFNSFL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TerrIFNSFL = group.Add(new VocabularyKey(nameof(TerrIFNSFL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OKATO = group.Add(new VocabularyKey(nameof(OKATO), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DivType = group.Add(new VocabularyKey(nameof(DivType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NextId = group.Add(new VocabularyKey(nameof(NextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrevId = group.Add(new VocabularyKey(nameof(PrevId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AOId { get; private set; }
public VocabularyKey AOGuid { get; private set; }
public VocabularyKey AOLevel { get; private set; }
public VocabularyKey RegionCode { get; private set; }
public VocabularyKey AreaCode { get; private set; }
public VocabularyKey CityCode { get; private set; }
public VocabularyKey CtArCode { get; private set; }
public VocabularyKey PlaceCode { get; private set; }
public VocabularyKey PlanCode { get; private set; }
public VocabularyKey StreetCode { get; private set; }
public VocabularyKey ExtrCode { get; private set; }
public VocabularyKey ActStatus { get; private set; }
public VocabularyKey LiveStatus { get; private set; }
public VocabularyKey OperStatus { get; private set; }
public VocabularyKey OffName { get; private set; }
public VocabularyKey ParentGuid { get; private set; }
public VocabularyKey ShortName { get; private set; }
public VocabularyKey PostalCode { get; private set; }
public VocabularyKey IFNSFL { get; private set; }
public VocabularyKey TerrIFNSFL { get; private set; }
public VocabularyKey OKATO { get; private set; }
public VocabularyKey DivType { get; private set; }
public VocabularyKey NextId { get; private set; }
public VocabularyKey PrevId { get; private set; }


    }
}
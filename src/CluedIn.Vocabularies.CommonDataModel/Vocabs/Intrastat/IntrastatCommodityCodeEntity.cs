using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatCommodityCodeEntityVocabulary : SimpleVocabulary
    {
        public IntrastatCommodityCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatCommodityCodeEntity";
            KeyPrefix = "commonDataModel.intrastatcommoditycodeentity";
            KeySeparator = ".";
            Grouping = "/IntrastatCommodityCodeEntity";

            AddGroup("Common Data Model IntrastatCommodityCodeEntity Details", group =>
            {
                AdditionalUnits = group.Add(new VocabularyKey(nameof(AdditionalUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Commodity = group.Add(new VocabularyKey(nameof(Commodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentCommodity = group.Add(new VocabularyKey(nameof(ParentCommodity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentName = group.Add(new VocabularyKey(nameof(ParentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptionalWeight = group.Add(new VocabularyKey(nameof(OptionalWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatParametersDataAreaId = group.Add(new VocabularyKey(nameof(IntrastatParametersDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AdditionalUnits { get; private set; }
public VocabularyKey Commodity { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ParentCommodity { get; private set; }
public VocabularyKey CommodityHierarchyName { get; private set; }
public VocabularyKey ParentName { get; private set; }
public VocabularyKey OptionalWeight { get; private set; }
public VocabularyKey IntrastatParametersDataAreaId { get; private set; }


    }
}
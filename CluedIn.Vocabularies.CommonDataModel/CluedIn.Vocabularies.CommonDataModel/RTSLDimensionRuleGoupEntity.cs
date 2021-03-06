using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLDimensionRuleGoupEntityVocabulary : SimpleVocabulary
    {
        public RTSLDimensionRuleGoupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTSLDimensionRuleGoupEntity";
            KeyPrefix = "commonDataModel.rtsldimensionrulegoupentity";
            KeySeparator = ".";
            Grouping = "/RTSLDimensionRuleGoupEntity";

            AddGroup("Common Data Model RTSLDimensionRuleGoupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimesionRuleGroupId = group.Add(new VocabularyKey(nameof(DimesionRuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RuleGroupId = group.Add(new VocabularyKey(nameof(RuleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey DimesionRuleGroupId { get; private set; }
public VocabularyKey RuleGroupId { get; private set; }


    }
}
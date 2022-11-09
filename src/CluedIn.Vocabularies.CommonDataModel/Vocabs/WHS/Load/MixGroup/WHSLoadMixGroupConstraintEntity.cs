using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLoadMixGroupConstraintEntityVocabulary : SimpleVocabulary
    {
        public WHSLoadMixGroupConstraintEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLoadMixGroupConstraintEntity";
            KeyPrefix = "commonDataModel.whsloadmixgroupconstraintentity";
            KeySeparator = ".";
            Grouping = "/WHSLoadMixGroupConstraintEntity";

            AddGroup("Common Data Model WHSLoadMixGroupConstraintEntity Details", group =>
            {
                LoadBuildAction = group.Add(new VocabularyKey(nameof(LoadBuildAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadMixGroupCriteria = group.Add(new VocabularyKey(nameof(LoadMixGroupCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstrainingProductGroupId = group.Add(new VocabularyKey(nameof(ConstrainingProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstrainingWarehouseFilterCode = group.Add(new VocabularyKey(nameof(ConstrainingWarehouseFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadMixGroupId = group.Add(new VocabularyKey(nameof(LoadMixGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadMixGroupCriterionProductGroupId = group.Add(new VocabularyKey(nameof(LoadMixGroupCriterionProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadMixGroupCriterionWarehouseFilterCode = group.Add(new VocabularyKey(nameof(LoadMixGroupCriterionWarehouseFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LoadBuildAction { get; private set; }
public VocabularyKey LoadMixGroupCriteria { get; private set; }
public VocabularyKey ConstrainingProductGroupId { get; private set; }
public VocabularyKey ConstrainingWarehouseFilterCode { get; private set; }
public VocabularyKey LoadMixGroupId { get; private set; }
public VocabularyKey LoadMixGroupCriterionProductGroupId { get; private set; }
public VocabularyKey LoadMixGroupCriterionWarehouseFilterCode { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeOMCostCenterEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeOMCostCenterEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeOMCostCenterEntity";
            KeyPrefix = "commonDataModel.dimattributeomcostcenterentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeOMCostCenterEntity";

            AddGroup("Common Data Model DimAttributeOMCostCenterEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
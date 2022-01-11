using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeInventItemGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeInventItemGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeInventItemGroupEntity";
            KeyPrefix = "commonDataModel.dimattributeinventitemgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeInventItemGroupEntity";

            AddGroup("Common Data Model DimAttributeInventItemGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
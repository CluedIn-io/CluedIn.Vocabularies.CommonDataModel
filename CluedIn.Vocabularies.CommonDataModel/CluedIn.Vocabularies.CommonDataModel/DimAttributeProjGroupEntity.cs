using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeProjGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeProjGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeProjGroupEntity";
            KeyPrefix = "commonDataModel.dimattributeprojgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeProjGroupEntity";

            AddGroup("Common Data Model DimAttributeProjGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
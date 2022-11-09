using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeCustGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeCustGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeCustGroupEntity";
            KeyPrefix = "commonDataModel.dimattributecustgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeCustGroupEntity";

            AddGroup("Common Data Model DimAttributeCustGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
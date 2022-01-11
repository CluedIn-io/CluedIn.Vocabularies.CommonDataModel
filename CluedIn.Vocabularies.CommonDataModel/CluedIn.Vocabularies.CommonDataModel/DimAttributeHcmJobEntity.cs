using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeHcmJobEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeHcmJobEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeHcmJobEntity";
            KeyPrefix = "commonDataModel.dimattributehcmjobentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeHcmJobEntity";

            AddGroup("Common Data Model DimAttributeHcmJobEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
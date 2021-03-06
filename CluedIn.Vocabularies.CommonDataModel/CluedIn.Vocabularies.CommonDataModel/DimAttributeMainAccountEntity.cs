using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeMainAccountEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeMainAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeMainAccountEntity";
            KeyPrefix = "commonDataModel.dimattributemainaccountentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeMainAccountEntity";

            AddGroup("Common Data Model DimAttributeMainAccountEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}
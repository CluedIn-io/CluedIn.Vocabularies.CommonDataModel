using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeVendTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeVendTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeVendTableEntity";
            KeyPrefix = "commonDataModel.dimattributevendtableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeVendTableEntity";

            AddGroup("Common Data Model DimAttributeVendTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
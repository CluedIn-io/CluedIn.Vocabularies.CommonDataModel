using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRetailChannelEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRetailChannelEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeRetailChannelEntity";
            KeyPrefix = "commonDataModel.dimattributeretailchannelentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRetailChannelEntity";

            AddGroup("Common Data Model DimAttributeRetailChannelEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
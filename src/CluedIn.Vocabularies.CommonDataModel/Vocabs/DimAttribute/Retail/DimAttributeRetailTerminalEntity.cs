using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRetailTerminalEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRetailTerminalEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeRetailTerminalEntity";
            KeyPrefix = "commonDataModel.dimattributeretailterminalentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRetailTerminalEntity";

            AddGroup("Common Data Model DimAttributeRetailTerminalEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
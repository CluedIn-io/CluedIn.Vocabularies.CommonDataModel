using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionCombinationEntityVocabulary : SimpleVocabulary
    {
        public DimensionCombinationEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimensionCombinationEntity";
            KeyPrefix = "commonDataModel.dimensioncombinationentity";
            KeySeparator = ".";
            Grouping = "/DimensionCombinationEntity";

            AddGroup("Common Data Model DimensionCombinationEntity Details", group =>
            {
                DisplayValue = group.Add(new VocabularyKey(nameof(DisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountStructure = group.Add(new VocabularyKey(nameof(AccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountValue = group.Add(new VocabularyKey(nameof(AccountValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DisplayValue { get; private set; }
public VocabularyKey AccountStructure { get; private set; }
public VocabularyKey RecordId { get; private set; }
public VocabularyKey AccountValue { get; private set; }
public VocabularyKey MainAccount { get; private set; }


    }
}
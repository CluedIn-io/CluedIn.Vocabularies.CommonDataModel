using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlotServiceTypeVocabulary : SimpleVocabulary
    {
        public SlotServiceTypeVocabulary()
        {
            VocabularyName = "Common Data Model SlotServiceType";
            KeyPrefix = "commonDataModel.slotservicetype";
            KeySeparator = ".";
            Grouping = "/SlotServiceType";

            AddGroup("Common Data Model SlotServiceType Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
slotServiceTypeId = group.Add(new VocabularyKey(nameof(slotServiceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey name { get; private set; }
public VocabularyKey slotServiceTypeId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}
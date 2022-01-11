using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlotSpecialtyVocabulary : SimpleVocabulary
    {
        public SlotSpecialtyVocabulary()
        {
            VocabularyName = "Common Data Model SlotSpecialty";
            KeyPrefix = "commonDataModel.slotspecialty";
            KeySeparator = ".";
            Grouping = "/SlotSpecialty";

            AddGroup("Common Data Model SlotSpecialty Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
slotSpecialtyId = group.Add(new VocabularyKey(nameof(slotSpecialtyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey name { get; private set; }
public VocabularyKey slotSpecialtyId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}
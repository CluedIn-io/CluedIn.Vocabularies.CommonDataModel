using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TransportationTypeTableEntityVocabulary : SimpleVocabulary
    {
        public TransportationTypeTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model TransportationTypeTableEntity";
            KeyPrefix = "commonDataModel.transportationtypetableentity";
            KeySeparator = ".";
            Grouping = "/TransportationTypeTableEntity";

            AddGroup("Common Data Model TransportationTypeTableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}
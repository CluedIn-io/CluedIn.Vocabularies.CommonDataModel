using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatTransportMethodEntityVocabulary : SimpleVocabulary
    {
        public IntrastatTransportMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatTransportMethodEntity";
            KeyPrefix = "commonDataModel.intrastattransportmethodentity";
            KeySeparator = ".";
            Grouping = "/IntrastatTransportMethodEntity";

            AddGroup("Common Data Model IntrastatTransportMethodEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Port { get; private set; }
public VocabularyKey Transport { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationMethodEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationMethodEntity";
            KeyPrefix = "commonDataModel.tmstransportationmethodentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationMethodEntity";

            AddGroup("Common Data Model TMSTransportationMethodEntity Details", group =>
            {
                MethodId = group.Add(new VocabularyKey(nameof(MethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodName = group.Add(new VocabularyKey(nameof(MethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MethodId { get; private set; }
public VocabularyKey MethodName { get; private set; }


    }
}
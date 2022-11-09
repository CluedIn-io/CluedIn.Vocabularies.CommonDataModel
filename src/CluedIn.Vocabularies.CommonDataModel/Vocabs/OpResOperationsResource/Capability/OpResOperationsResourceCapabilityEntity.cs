using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceCapabilityEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceCapabilityEntityVocabulary()
        {
            VocabularyName = "Common Data Model OpResOperationsResourceCapabilityEntity";
            KeyPrefix = "commonDataModel.opresoperationsresourcecapabilityentity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceCapabilityEntity";

            AddGroup("Common Data Model OpResOperationsResourceCapabilityEntity Details", group =>
            {
                CapabilityDescription = group.Add(new VocabularyKey(nameof(CapabilityDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CapabilityName = group.Add(new VocabularyKey(nameof(CapabilityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CapabilityDescription { get; private set; }
public VocabularyKey CapabilityName { get; private set; }


    }
}
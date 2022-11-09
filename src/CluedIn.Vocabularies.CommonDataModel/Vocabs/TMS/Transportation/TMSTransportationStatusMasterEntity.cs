using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationStatusMasterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationStatusMasterEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationStatusMasterEntity";
            KeyPrefix = "commonDataModel.tmstransportationstatusmasterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationStatusMasterEntity";

            AddGroup("Common Data Model TMSTransportationStatusMasterEntity Details", group =>
            {
                MasterDescription = group.Add(new VocabularyKey(nameof(MasterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationType = group.Add(new VocabularyKey(nameof(TransportationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterName = group.Add(new VocabularyKey(nameof(MasterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterCode = group.Add(new VocabularyKey(nameof(MasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MasterDescription { get; private set; }
public VocabularyKey TransportationType { get; private set; }
public VocabularyKey MasterName { get; private set; }
public VocabularyKey MasterCode { get; private set; }


    }
}
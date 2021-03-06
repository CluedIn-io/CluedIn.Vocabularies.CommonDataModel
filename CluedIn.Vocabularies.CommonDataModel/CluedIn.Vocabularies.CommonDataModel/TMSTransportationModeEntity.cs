using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationModeEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationModeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationModeEntity";
            KeyPrefix = "commonDataModel.tmstransportationmodeentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationModeEntity";

            AddGroup("Common Data Model TMSTransportationModeEntity Details", group =>
            {
                ModeCode = group.Add(new VocabularyKey(nameof(ModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModeDescription = group.Add(new VocabularyKey(nameof(ModeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ModeCode { get; private set; }
public VocabularyKey ModeDescription { get; private set; }


    }
}
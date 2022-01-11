using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRChannelUserEntityVocabulary : SimpleVocabulary
    {
        public MCRChannelUserEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRChannelUserEntity";
            KeyPrefix = "commonDataModel.mcrchanneluserentity";
            KeySeparator = ".";
            Grouping = "/MCRChannelUserEntity";

            AddGroup("Common Data Model MCRChannelUserEntity Details", group =>
            {
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
User = group.Add(new VocabularyKey(nameof(User), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitId = group.Add(new VocabularyKey(nameof(OperatingUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey User { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey OperatingUnitId { get; private set; }


    }
}
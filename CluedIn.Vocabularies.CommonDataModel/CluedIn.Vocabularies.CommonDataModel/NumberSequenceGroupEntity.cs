using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NumberSequenceGroupEntityVocabulary : SimpleVocabulary
    {
        public NumberSequenceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model NumberSequenceGroupEntity";
            KeyPrefix = "commonDataModel.numbersequencegroupentity";
            KeySeparator = ".";
            Grouping = "/NumberSequenceGroupEntity";

            AddGroup("Common Data Model NumberSequenceGroupEntity Details", group =>
            {
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey description { get; private set; }
public VocabularyKey NumberSequenceGroup { get; private set; }


    }
}
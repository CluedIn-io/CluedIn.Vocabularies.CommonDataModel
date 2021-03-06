using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmBusinessSegmentEntityVocabulary : SimpleVocabulary
    {
        public smmBusinessSegmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmBusinessSegmentEntity";
            KeyPrefix = "commonDataModel.smmbusinesssegmententity";
            KeySeparator = ".";
            Grouping = "/smmBusinessSegmentEntity";

            AddGroup("Common Data Model smmBusinessSegmentEntity Details", group =>
            {
                SegmentDescription = group.Add(new VocabularyKey(nameof(SegmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SegmentCode = group.Add(new VocabularyKey(nameof(SegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SegmentDescription { get; private set; }
public VocabularyKey SegmentCode { get; private set; }


    }
}
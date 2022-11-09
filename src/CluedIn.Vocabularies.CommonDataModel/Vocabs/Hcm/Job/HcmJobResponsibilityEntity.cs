using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobResponsibilityEntityVocabulary : SimpleVocabulary
    {
        public HcmJobResponsibilityEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobResponsibilityEntity";
            KeyPrefix = "commonDataModel.hcmjobresponsibilityentity";
            KeySeparator = ".";
            Grouping = "/HcmJobResponsibilityEntity";

            AddGroup("Common Data Model HcmJobResponsibilityEntity Details", group =>
            {
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreaOfResponsibility = group.Add(new VocabularyKey(nameof(AreaOfResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreaOfResponsibilityId = group.Add(new VocabularyKey(nameof(AreaOfResponsibilityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Job { get; private set; }
public VocabularyKey JobId { get; private set; }
public VocabularyKey Note { get; private set; }
public VocabularyKey AreaOfResponsibility { get; private set; }
public VocabularyKey AreaOfResponsibilityId { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCFDANumberEntityVocabulary : SimpleVocabulary
    {
        public ProjCFDANumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjCFDANumberEntity";
            KeyPrefix = "commonDataModel.projcfdanumberentity";
            KeySeparator = ".";
            Grouping = "/ProjCFDANumberEntity";

            AddGroup("Common Data Model ProjCFDANumberEntity Details", group =>
            {
                CFDAClusterName = group.Add(new VocabularyKey(nameof(CFDAClusterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFDAID = group.Add(new VocabularyKey(nameof(CFDAID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CFDAClusterName { get; private set; }
public VocabularyKey CFDAID { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}
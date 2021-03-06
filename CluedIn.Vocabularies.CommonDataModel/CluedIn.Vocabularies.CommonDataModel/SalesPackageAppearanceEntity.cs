using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPackageAppearanceEntityVocabulary : SimpleVocabulary
    {
        public SalesPackageAppearanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesPackageAppearanceEntity";
            KeyPrefix = "commonDataModel.salespackageappearanceentity";
            KeySeparator = ".";
            Grouping = "/SalesPackageAppearanceEntity";

            AddGroup("Common Data Model SalesPackageAppearanceEntity Details", group =>
            {
                AppearanceId = group.Add(new VocabularyKey(nameof(AppearanceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AppearanceDescription = group.Add(new VocabularyKey(nameof(AppearanceDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AppearanceId { get; private set; }
public VocabularyKey AppearanceDescription { get; private set; }


    }
}
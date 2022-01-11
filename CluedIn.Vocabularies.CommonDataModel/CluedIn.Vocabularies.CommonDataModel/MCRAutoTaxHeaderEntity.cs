using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRAutoTaxHeaderEntityVocabulary : SimpleVocabulary
    {
        public MCRAutoTaxHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRAutoTaxHeaderEntity";
            KeyPrefix = "commonDataModel.mcrautotaxheaderentity";
            KeySeparator = ".";
            Grouping = "/MCRAutoTaxHeaderEntity";

            AddGroup("Common Data Model MCRAutoTaxHeaderEntity Details", group =>
            {
                Warnings = group.Add(new VocabularyKey(nameof(Warnings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Warnings { get; private set; }


    }
}
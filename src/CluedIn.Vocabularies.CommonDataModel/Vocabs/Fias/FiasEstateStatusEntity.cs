using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasEstateStatusEntityVocabulary : SimpleVocabulary
    {
        public FiasEstateStatusEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiasEstateStatusEntity";
            KeyPrefix = "commonDataModel.fiasestatestatusentity";
            KeySeparator = ".";
            Grouping = "/FiasEstateStatusEntity";

            AddGroup("Common Data Model FiasEstateStatusEntity Details", group =>
            {
                EstStatId = group.Add(new VocabularyKey(nameof(EstStatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EstStatId { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}
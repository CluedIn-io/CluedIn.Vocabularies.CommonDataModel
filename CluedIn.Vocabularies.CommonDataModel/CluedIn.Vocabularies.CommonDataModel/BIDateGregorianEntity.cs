using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BIDateGregorianEntityVocabulary : SimpleVocabulary
    {
        public BIDateGregorianEntityVocabulary()
        {
            VocabularyName = "Common Data Model BIDateGregorianEntity";
            KeyPrefix = "commonDataModel.bidategregorianentity";
            KeySeparator = ".";
            Grouping = "/BIDateGregorianEntity";

            AddGroup("Common Data Model BIDateGregorianEntity Details", group =>
            {
                GregorianDate = group.Add(new VocabularyKey(nameof(GregorianDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GregorianDateId = group.Add(new VocabularyKey(nameof(GregorianDateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GregorianDate { get; private set; }
public VocabularyKey GregorianDateId { get; private set; }


    }
}
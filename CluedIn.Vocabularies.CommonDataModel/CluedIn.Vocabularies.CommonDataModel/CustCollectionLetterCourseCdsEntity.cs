using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionLetterCourseCdsEntityVocabulary : SimpleVocabulary
    {
        public CustCollectionLetterCourseCdsEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionLetterCourseCdsEntity";
            KeyPrefix = "commonDataModel.custcollectionlettercoursecdsentity";
            KeySeparator = ".";
            Grouping = "/CustCollectionLetterCourseCdsEntity";

            AddGroup("Common Data Model CustCollectionLetterCourseCdsEntity Details", group =>
            {
                CollectionLetterCourse = group.Add(new VocabularyKey(nameof(CollectionLetterCourse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CollectionLetterCourse { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}
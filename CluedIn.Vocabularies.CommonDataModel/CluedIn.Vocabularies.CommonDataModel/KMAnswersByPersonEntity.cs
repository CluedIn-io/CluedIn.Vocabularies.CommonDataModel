using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class KMAnswersByPersonEntityVocabulary : SimpleVocabulary
    {
        public KMAnswersByPersonEntityVocabulary()
        {
            VocabularyName = "Common Data Model KMAnswersByPersonEntity";
            KeyPrefix = "commonDataModel.kmanswersbypersonentity";
            KeySeparator = ".";
            Grouping = "/KMAnswersByPersonEntity";

            AddGroup("Common Data Model KMAnswersByPersonEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionId = group.Add(new VocabularyKey(nameof(CollectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionId = group.Add(new VocabularyKey(nameof(QuestionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionText = group.Add(new VocabularyKey(nameof(QuestionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnswerText = group.Add(new VocabularyKey(nameof(AnswerText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnswerId = group.Add(new VocabularyKey(nameof(AnswerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey CollectionId { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey QuestionId { get; private set; }
public VocabularyKey QuestionText { get; private set; }
public VocabularyKey AnswerText { get; private set; }
public VocabularyKey Comment { get; private set; }
public VocabularyKey AnswerId { get; private set; }


    }
}
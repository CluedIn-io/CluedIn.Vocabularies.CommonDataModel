using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInFormQuestionVocabulary : SimpleVocabulary
    {
        public LinkedInFormQuestionVocabulary()
        {
            VocabularyName = "Common Data Model LinkedInFormQuestion";
            KeyPrefix = "commonDataModel.linkedinformquestion";
            KeySeparator = ".";
            Grouping = "/LinkedInFormQuestion";

            AddGroup("Common Data Model LinkedInFormQuestion Details", group =>
            {
                displayName = group.Add(new VocabularyKey(nameof(displayName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isConsentCheckbox = group.Add(new VocabularyKey(nameof(isConsentCheckbox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isCustomQuestion = group.Add(new VocabularyKey(nameof(isCustomQuestion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedInFormQuestionId = group.Add(new VocabularyKey(nameof(linkedInFormQuestionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedInID = group.Add(new VocabularyKey(nameof(linkedInID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
responseEditable = group.Add(new VocabularyKey(nameof(responseEditable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
responseType = group.Add(new VocabularyKey(nameof(responseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey displayName { get; private set; }
public VocabularyKey isConsentCheckbox { get; private set; }
public VocabularyKey isCustomQuestion { get; private set; }
public VocabularyKey linkedInFormQuestionId { get; private set; }
public VocabularyKey linkedInID { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey responseEditable { get; private set; }
public VocabularyKey responseType { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}
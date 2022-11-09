using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocAuthorityStateEntityVocabulary : SimpleVocabulary
    {
        public EFDocAuthorityStateEntityVocabulary()
        {
            VocabularyName = "Common Data Model EFDocAuthorityStateEntity";
            KeyPrefix = "commonDataModel.efdocauthoritystateentity";
            KeySeparator = ".";
            Grouping = "/EFDocAuthorityStateEntity";

            AddGroup("Common Data Model EFDocAuthorityStateEntity Details", group =>
            {
                Authority = group.Add(new VocabularyKey(nameof(Authority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddExempt = group.Add(new VocabularyKey(nameof(AddExempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateBenefitCodes = group.Add(new VocabularyKey(nameof(ValidateBenefitCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Authority { get; private set; }
public VocabularyKey StateId { get; private set; }
public VocabularyKey State { get; private set; }
public VocabularyKey AddExempt { get; private set; }
public VocabularyKey ValidateBenefitCodes { get; private set; }


    }
}
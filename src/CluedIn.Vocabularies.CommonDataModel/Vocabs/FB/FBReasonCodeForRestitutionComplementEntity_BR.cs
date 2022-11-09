using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBReasonCodeForRestitutionComplementEntity_BRVocabulary : SimpleVocabulary
    {
        public FBReasonCodeForRestitutionComplementEntity_BRVocabulary()
        {
            VocabularyName = "Common Data Model FBReasonCodeForRestitutionComplementEntity_BR";
            KeyPrefix = "commonDataModel.fbreasoncodeforrestitutioncomplemententity_br";
            KeySeparator = ".";
            Grouping = "/FBReasonCodeForRestitutionComplementEntity_BR";

            AddGroup("Common Data Model FBReasonCodeForRestitutionComplementEntity_BR Details", group =>
            {
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Classification = group.Add(new VocabularyKey(nameof(Classification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpedCode = group.Add(new VocabularyKey(nameof(SpedCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OccurrenceCode = group.Add(new VocabularyKey(nameof(OccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReasonCode { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey State { get; private set; }
public VocabularyKey Classification { get; private set; }
public VocabularyKey SpedCode { get; private set; }
public VocabularyKey OccurrenceCode { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }


    }
}
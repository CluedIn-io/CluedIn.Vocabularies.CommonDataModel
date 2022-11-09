using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AgreementExternalAgreementClassificationCodeEntityVocabulary : SimpleVocabulary
    {
        public AgreementExternalAgreementClassificationCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model AgreementExternalAgreementClassificationCodeEntity";
            KeyPrefix = "commonDataModel.agreementexternalagreementclassificationcodeentity";
            KeySeparator = ".";
            Grouping = "/AgreementExternalAgreementClassificationCodeEntity";

            AddGroup("Common Data Model AgreementExternalAgreementClassificationCodeEntity Details", group =>
            {
                CodeDefinition = group.Add(new VocabularyKey(nameof(CodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeDescription = group.Add(new VocabularyKey(nameof(CodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeId = group.Add(new VocabularyKey(nameof(CodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsStandardCode = group.Add(new VocabularyKey(nameof(IsStandardCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CodeDefinition { get; private set; }
public VocabularyKey CodeDescription { get; private set; }
public VocabularyKey CodeId { get; private set; }
public VocabularyKey IsStandardCode { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPayAgreementExceptionEntityVocabulary : SimpleVocabulary
    {
        public JmgPayAgreementExceptionEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgPayAgreementExceptionEntity";
            KeyPrefix = "commonDataModel.jmgpayagreementexceptionentity";
            KeySeparator = ".";
            Grouping = "/JmgPayAgreementExceptionEntity";

            AddGroup("Common Data Model JmgPayAgreementExceptionEntity Details", group =>
            {
                ExceptionId = group.Add(new VocabularyKey(nameof(ExceptionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AbsenceCode = group.Add(new VocabularyKey(nameof(AbsenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedPayRate = group.Add(new VocabularyKey(nameof(FixedPayRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIncludedInPayAgreement = group.Add(new VocabularyKey(nameof(IsIncludedInPayAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExceptionId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey AbsenceCode { get; private set; }
public VocabularyKey FixedPayRate { get; private set; }
public VocabularyKey IsIncludedInPayAgreement { get; private set; }


    }
}
using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobPreferredCertificateEntityVocabulary : SimpleVocabulary
    {
        public HcmJobPreferredCertificateEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobPreferredCertificateEntity";
            KeyPrefix = "commonDataModel.hcmjobpreferredcertificateentity";
            KeySeparator = ".";
            Grouping = "/HcmJobPreferredCertificateEntity";

            AddGroup("Common Data Model HcmJobPreferredCertificateEntity Details", group =>
            {
                CertificateType = group.Add(new VocabularyKey(nameof(CertificateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertificateTypeId = group.Add(new VocabularyKey(nameof(CertificateTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Importance = group.Add(new VocabularyKey(nameof(Importance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CertificateType { get; private set; }
public VocabularyKey CertificateTypeId { get; private set; }
public VocabularyKey Importance { get; private set; }
public VocabularyKey Job { get; private set; }
public VocabularyKey JobId { get; private set; }


    }
}
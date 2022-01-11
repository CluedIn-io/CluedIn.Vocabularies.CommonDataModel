using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxCertificateEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxCertificateEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicTaxCertificateEntity";
            KeyPrefix = "commonDataModel.electronictaxcertificateentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxCertificateEntity";

            AddGroup("Common Data Model ElectronicTaxCertificateEntity Details", group =>
            {
                CertificatesReference = group.Add(new VocabularyKey(nameof(CertificatesReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertificateType = group.Add(new VocabularyKey(nameof(CertificateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CertificatesReference { get; private set; }
public VocabularyKey CertificateType { get; private set; }
public VocabularyKey UserId { get; private set; }
public VocabularyKey Company { get; private set; }


    }
}